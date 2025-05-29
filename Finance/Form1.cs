using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Finance
{
    public partial class Form1 : Form
    {
        // ========== 1. Proměnné a konstruktor ==========

        public readonly string categoryFilePath = Path.Combine(Application.StartupPath, "categories.txt");

        public Form1()
        {
            InitializeComponent();

            // Události pro změnu filtrů
            cmbBoxCategory.SelectedIndexChanged += FilterChanged;
            cmbBoxType.SelectedIndexChanged += FilterChanged;
            cmbBoxYear.SelectedIndexChanged += FilterChanged;
            cmbBoxMonth.SelectedIndexChanged += MonthChanged;

            // Inicializace dat
            LoadCategoriesFromFile();
            Database.Initialize();
            LoadYearComboBox();
            ApplyFilters();
            UpdateBalanceLabel();
        }

        // ========== 2. Obsluha událostí ==========

        private void FilterChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void MonthChanged(object sender, EventArgs e)
        {
            // Pokud je vybrán měsíc ale není vybrán rok, zobraz chybovou hlášku
            if (cmbBoxYear.SelectedIndex == -1 && cmbBoxMonth.SelectedIndex != -1)
            {
                MessageBox.Show("Nejdříve vyberte rok.", "Chyba filtru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBoxMonth.SelectedIndex = -1;
                return;
            }

            ApplyFilters();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new FormTransaction();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadYearComboBox();
                ApplyFilters();
                UpdateBalanceLabel();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;

            int id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value);
            var transaction = Database.GetTransactionById(id);
            if (transaction == null) return;

            var form = new FormTransaction(transaction);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadYearComboBox();
                ApplyFilters();
                UpdateBalanceLabel();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;

            int id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value);
            var result = MessageBox.Show("Opravdu chcete smazat tuto transakci?", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Database.DeleteTransaction(id);
                ApplyFilters();
                UpdateBalanceLabel();
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            cmbBoxCategory.SelectedIndex = -1;
            cmbBoxType.SelectedIndex = -1;
            cmbBoxMonth.SelectedIndex = -1;
            cmbBoxYear.SelectedIndex = -1;

            ApplyFilters();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategoryForm = new AddCategory(this);
            addCategoryForm.ShowDialog();
        }

        // ========== 3. Načtení dat do UI ==========

        private void LoadYearComboBox()
        {
            var years = Database.GetAllTransactions()
                .Select(t => t.Date.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToList();

            cmbBoxYear.Items.Clear();
            foreach (var year in years)
                cmbBoxYear.Items.Add(year);

            if (cmbBoxYear.Items.Count > 0)
                cmbBoxYear.SelectedIndex = -1;
        }

        private void LoadDataToGrid()
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("Id", "ID");
            dgv.Columns["Id"].Visible = false;
            dgv.Columns.Add("Name", "Název");
            dgv.Columns.Add("Amount", "Částka");
            dgv.Columns.Add("Category", "Kategorie");
            dgv.Columns.Add("Type", "Typ");
            dgv.Columns.Add("Date", "Datum");

            var transactions = GetFilteredTransactions();

            foreach (var t in transactions)
            {
                string type = t.Type == "Income" ? "Příchozí" : "Odchozí";
                dgv.Rows.Add(t.Id, t.Name, t.Amount, t.Category, type, t.Date.ToString("dd-MM-yyyy"));
            }

            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // ========== 4. Filtrování a zpracování dat ==========

        private void ApplyFilters()
        {
            LoadDataToGrid();
            LoadCategoryChart();
            LoadMonthlyChart();
        }

        private List<Transaction> GetFilteredTransactions()
        {
            var transactions = Database.GetAllTransactions();

            if (cmbBoxCategory.SelectedIndex != -1)
                transactions = transactions.Where(t => t.Category == cmbBoxCategory.SelectedItem.ToString()).ToList();

            if (cmbBoxType.SelectedIndex != -1)
            {
                var selectedType = cmbBoxType.SelectedItem.ToString();
                if (selectedType == "Příchozí")
                    transactions = transactions.Where(t => t.Type == "Income").ToList();
                else if (selectedType == "Odchozí")
                    transactions = transactions.Where(t => t.Type == "Expense").ToList();
            }

            if (cmbBoxMonth.SelectedIndex != -1)
                transactions = transactions.Where(t => t.Date.Month == cmbBoxMonth.SelectedIndex + 1).ToList();

            if (cmbBoxYear.SelectedIndex != -1)
                transactions = transactions.Where(t => t.Date.Year == Convert.ToInt32(cmbBoxYear.SelectedItem)).ToList();

            return transactions;
        }

        // ========== 5. Vykreslení grafů ==========

        private void LoadCategoryChart()
        {
            var transactions = GetFilteredTransactions();

            var categoryData = transactions
                .GroupBy(t => t.Category)
                .Select(g => new { Category = g.Key, Amount = g.Sum(t => t.Amount) })
                .ToList();

            chartCategory.Series.Clear();

            var series = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            foreach (var item in categoryData)
            {
                series.Points.AddXY(item.Category, item.Amount);
            }

            chartCategory.Series.Add(series);
        }

        private void LoadMonthlyChart()
        {
            string text = "Vývoj zůstatku";

            if (cmbBoxYear.SelectedIndex != -1)
            {
                text += $" pro rok {cmbBoxYear.SelectedItem}";
                if (cmbBoxMonth.SelectedIndex != -1)
                {
                    string monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(cmbBoxMonth.SelectedIndex + 1);
                    text += $" za měsíc {char.ToUpper(monthName[0]) + monthName.Substring(1)}";
                }
            }

            labelVyvoj.Text = text;

            var transactions = Database.GetAllTransactions();

            if (cmbBoxMonth.SelectedIndex != -1)
                transactions = transactions.Where(t => t.Date.Month == cmbBoxMonth.SelectedIndex + 1).ToList();

            if (cmbBoxYear.SelectedIndex != -1)
                transactions = transactions.Where(t => t.Date.Year == Convert.ToInt32(cmbBoxYear.SelectedItem)).ToList();

            var sortedTransactions = transactions.OrderBy(t => t.Date).ToList();

            chartMonth.Series.Clear();
            chartMonth.ChartAreas.Clear();
            chartMonth.ChartAreas.Add(new ChartArea("MainArea"));

            var balanceSeries = new Series("Zůstatek")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Gold,
                BorderWidth = 4,
                XValueType = ChartValueType.DateTime,
                IsValueShownAsLabel = false
            };

            decimal balance = 0;
            foreach (var t in sortedTransactions)
            {
                balance += (t.Type == "Income" ? 1 : -1) * (decimal)t.Amount;
                balanceSeries.Points.AddXY(t.Date, balance);
            }

            chartMonth.Series.Add(balanceSeries);
        }

        // ========== 6. Práce s kategoriemi ==========

        public void AddCategoryToCombo(string category)
        {
            if (!cmbBoxCategory.Items.Contains(category))
            {
                cmbBoxCategory.Items.Add(category);
                SaveCategoryToFile(category);
            }
        }

        private void LoadCategoriesFromFile()
        {
            if (File.Exists(categoryFilePath))
            {
                var categories = File.ReadAllLines(categoryFilePath);
                foreach (var category in categories)
                {
                    if (!string.IsNullOrWhiteSpace(category) && !cmbBoxCategory.Items.Contains(category))
                    {
                        cmbBoxCategory.Items.Add(category);
                    }
                }
            }
        }

        private void SaveCategoryToFile(string category)
        {
            File.AppendAllText(categoryFilePath, category + Environment.NewLine);
        }

        // ========== 7. Pomocné metody ==========

        private void UpdateBalanceLabel()
        {
            double balance = Database.GetBalance();
            labelBalance.Text = $"Aktuální zůstatek: {balance:0.00} Kč";
        }
    }
}
