using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Information_Management_Finals_Generator.forms.categories
{
    public partial class frmAddCategory : Form
    {
        components.Values val = new components.Values();
        functions.Category category = new functions.Category();

        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text))
            {
                if (category.AddCategory(txtName.Text))
                {
                    MessageBox.Show("Category saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Name field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
