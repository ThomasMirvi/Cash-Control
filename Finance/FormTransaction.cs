using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Finance
{
    public partial class FormTransaction : Form
    {
        private readonly bool isEditMode;
        private readonly int? transactionId;

        public FormTransaction()
        {
            InitializeComponent();
            LoadCategories();
            isEditMode = false;
            labelTrans.Text = " PŘIDAT TRANSAKCI";
        }

        public FormTransaction(Transaction existing) // pro editaci
        {
            InitializeComponent();
            LoadCategories();
            isEditMode = true;
            transactionId = existing.Id;

            txtName.Text = existing.Name;
            numAmount.Value = (decimal)existing.Amount;
            cmbCategory.Text = existing.Category;
            cmbType.Text = existing.Type;
            datePicker.Value = existing.Date;
            labelTrans.Text = " UPRAVIT TRANSAKCI";
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            // Načteme hodnoty z formuláře
            string name = txtName.Text.Trim();
            double amount = (double)numAmount.Value;
            string category = cmbCategory.Text;
            string type = cmbType.Text;
            DateTime date = datePicker.Value;

            // Ověření, že všechny povinné hodnoty jsou vyplněné
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vyplňte prosím název transakce.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Částka musí být větší než nula.");
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Vyberte kategorii.");
                return;
            }

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Vyberte typ transakce (Příchozí / Odchozí).");
                return;
            }

            // Převod českého typu na anglický typ pro databázi
            string dbType = type == "Příchozí" ? "Income" : "Expense";

            if (isEditMode && transactionId.HasValue)
            {
                // Uprav existující transakci
                var updated = new Transaction
                {
                    Id = transactionId.Value,
                    Name = name,
                    Amount = amount,
                    Category = category,
                    Type = dbType,
                    Date = date
                };

                Database.UpdateTransaction(updated);
            }
            else
            {
                // Přidej novou transakci
                Database.AddTransaction(name, amount, category, dbType, date);
            }

            // Zavřeme formulář s výsledkem OK
            this.DialogResult = DialogResult.OK;
            
            this.Close();
        }





        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCategories()
        {
            string path = "categories.txt";

            if (File.Exists(path))
            {
                var categories = File.ReadAllLines(path);
                cmbCategory.Items.Clear();
                cmbCategory.Items.AddRange(categories);
            }
            else
            {
                MessageBox.Show("Soubor categories.txt nebyl nalezen.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
