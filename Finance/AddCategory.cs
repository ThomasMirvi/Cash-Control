using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    public partial class AddCategory : Form
    {
        private Form1 mainForm;

        public AddCategory(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            string newCategory = txtNewCategory.Text.Trim();

            if (!string.IsNullOrEmpty(newCategory))
            {
                mainForm.AddCategoryToCombo(newCategory);

                this.Close();
            }
            else
            {
                MessageBox.Show("Zadej název kategorie.");
            }
        }
    }

}
