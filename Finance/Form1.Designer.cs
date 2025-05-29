namespace Finance
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelVyvoj = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.cmbBoxYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.cmbBoxMonth = new System.Windows.Forms.ComboBox();
            this.cmbBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxTransakce = new System.Windows.Forms.GroupBox();
            this.groupBoxZustatek = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTransakce.SuspendLayout();
            this.groupBoxZustatek.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.Location = new System.Drawing.Point(11, 153);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 55;
            this.dgv.Size = new System.Drawing.Size(1123, 292);
            this.dgv.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(11, 453);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Přidat...";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(147, 453);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 36);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Upravit...";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(283, 453);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Smazat";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chartCategory
            // 
            this.chartCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chartCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartCategory.BorderlineColor = System.Drawing.Color.Gold;
            this.chartCategory.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartCategory.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chartCategory.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCategory.Legends.Add(legend1);
            this.chartCategory.Location = new System.Drawing.Point(1254, 526);
            this.chartCategory.Margin = new System.Windows.Forms.Padding(4);
            this.chartCategory.Name = "chartCategory";
            this.chartCategory.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCategory.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Gold,
        System.Drawing.Color.Brown,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.Orange,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.Chocolate,
        System.Drawing.Color.BlueViolet};
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCategory.Series.Add(series1);
            this.chartCategory.Size = new System.Drawing.Size(734, 445);
            this.chartCategory.TabIndex = 10;
            this.chartCategory.Text = "chartCategory";
            title1.BackColor = System.Drawing.Color.Gold;
            title1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            title1.BorderWidth = 2;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Kategorie";
            title1.Text = "Kategorie";
            this.chartCategory.Titles.Add(title1);
            // 
            // chartMonth
            // 
            this.chartMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartMonth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chartMonth.BorderlineColor = System.Drawing.Color.Gold;
            this.chartMonth.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartMonth.BorderlineWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.chartMonth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMonth.Legends.Add(legend2);
            this.chartMonth.Location = new System.Drawing.Point(13, 76);
            this.chartMonth.Margin = new System.Windows.Forms.Padding(4);
            this.chartMonth.Name = "chartMonth";
            this.chartMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMonth.Series.Add(series2);
            this.chartMonth.Size = new System.Drawing.Size(1945, 245);
            this.chartMonth.TabIndex = 11;
            this.chartMonth.Text = "chartMonth";
            // 
            // labelVyvoj
            // 
            this.labelVyvoj.AutoSize = true;
            this.labelVyvoj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVyvoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVyvoj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVyvoj.Location = new System.Drawing.Point(10, 18);
            this.labelVyvoj.Name = "labelVyvoj";
            this.labelVyvoj.Size = new System.Drawing.Size(225, 38);
            this.labelVyvoj.TabIndex = 15;
            this.labelVyvoj.Text = "Vývoj zůstatku";
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBalance.AutoSize = true;
            this.labelBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBalance.Location = new System.Drawing.Point(1440, 18);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(199, 38);
            this.labelBalance.TabIndex = 18;
            this.labelBalance.Text = "labelBalance";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Gold;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Controls.Add(this.label6);
            this.panelLogo.Controls.Add(this.label5);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(2031, 111);
            this.panelLogo.TabIndex = 19;
            this.panelLogo.Tag = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1766, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "© 2025 Tomáš Mirvald";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(600, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(687, 93);
            this.label5.TabIndex = 20;
            this.label5.Text = "CASH CONTROL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategorie:";
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(132, 66);
            this.cmbBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(117, 30);
            this.cmbBoxCategory.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rok:";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetFilter.Location = new System.Drawing.Point(994, 61);
            this.btnResetFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(164, 36);
            this.btnResetFilter.TabIndex = 14;
            this.btnResetFilter.Text = "Resetovat filtr";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // cmbBoxYear
            // 
            this.cmbBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxYear.FormattingEnabled = true;
            this.cmbBoxYear.Location = new System.Drawing.Point(103, 34);
            this.cmbBoxYear.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxYear.Name = "cmbBoxYear";
            this.cmbBoxYear.Size = new System.Drawing.Size(117, 30);
            this.cmbBoxYear.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(256, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Měsíc:";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCategory.Location = new System.Drawing.Point(132, 30);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(117, 28);
            this.btnAddCategory.TabIndex = 16;
            this.btnAddCategory.Text = "Přidat kategorii";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // cmbBoxMonth
            // 
            this.cmbBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxMonth.FormattingEnabled = true;
            this.cmbBoxMonth.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen",
            "Červenec",
            "Srpen",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
            this.cmbBoxMonth.Location = new System.Drawing.Point(352, 33);
            this.cmbBoxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxMonth.Name = "cmbBoxMonth";
            this.cmbBoxMonth.Size = new System.Drawing.Size(117, 30);
            this.cmbBoxMonth.TabIndex = 2;
            // 
            // cmbBoxType
            // 
            this.cmbBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxType.FormattingEnabled = true;
            this.cmbBoxType.Items.AddRange(new object[] {
            "Příchozí",
            "Odchozí"});
            this.cmbBoxType.Location = new System.Drawing.Point(361, 67);
            this.cmbBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxType.Name = "cmbBoxType";
            this.cmbBoxType.Size = new System.Drawing.Size(117, 30);
            this.cmbBoxType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(288, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Typ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnResetFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBoxType);
            this.groupBox1.Controls.Add(this.cmbBoxCategory);
            this.groupBox1.Controls.Add(this.btnAddCategory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(11, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 110);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtr transakcí";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBoxMonth);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbBoxYear);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(502, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 76);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtr zůstatku";
            // 
            // groupBoxTransakce
            // 
            this.groupBoxTransakce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTransakce.Controls.Add(this.groupBox1);
            this.groupBoxTransakce.Controls.Add(this.btnDelete);
            this.groupBoxTransakce.Controls.Add(this.btnEdit);
            this.groupBoxTransakce.Controls.Add(this.btnAdd);
            this.groupBoxTransakce.Controls.Add(this.dgv);
            this.groupBoxTransakce.Location = new System.Drawing.Point(27, 505);
            this.groupBoxTransakce.Name = "groupBoxTransakce";
            this.groupBoxTransakce.Size = new System.Drawing.Size(1220, 496);
            this.groupBoxTransakce.TabIndex = 21;
            this.groupBoxTransakce.TabStop = false;
            // 
            // groupBoxZustatek
            // 
            this.groupBoxZustatek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxZustatek.Controls.Add(this.labelBalance);
            this.groupBoxZustatek.Controls.Add(this.labelVyvoj);
            this.groupBoxZustatek.Controls.Add(this.chartMonth);
            this.groupBoxZustatek.Location = new System.Drawing.Point(27, 132);
            this.groupBoxZustatek.Name = "groupBoxZustatek";
            this.groupBoxZustatek.Size = new System.Drawing.Size(1975, 337);
            this.groupBoxZustatek.TabIndex = 22;
            this.groupBoxZustatek.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(2031, 1033);
            this.Controls.Add(this.groupBoxZustatek);
            this.Controls.Add(this.groupBoxTransakce);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.chartCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CASHCONTROL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTransakce.ResumeLayout(false);
            this.groupBoxZustatek.ResumeLayout(false);
            this.groupBoxZustatek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonth;
        private System.Windows.Forms.Label labelVyvoj;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.ComboBox cmbBoxYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ComboBox cmbBoxMonth;
        private System.Windows.Forms.ComboBox cmbBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxTransakce;
        private System.Windows.Forms.GroupBox groupBoxZustatek;
        private System.Windows.Forms.Label label6;
    }
}

