using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Information_Management_Finals_Generator.forms.input
{
    public partial class frmInput : Form
    {
        components.Values val = new components.Values();
        functions.Query query = new functions.Query();
        
        public frmInput()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            if (!query.ExecuteQuery(txtSQL.Text, dtgResult))
            {
                string newLine = Environment.NewLine;
                txtMessage.Text = txtSQL.Text + newLine + val.ErrorMessage;
            };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
        }
    }
}
