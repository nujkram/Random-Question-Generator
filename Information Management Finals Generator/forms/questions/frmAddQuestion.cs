using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Information_Management_Finals_Generator.forms.questions
{
    public partial class frmAddQuestion : Form
    {
        components.Values val = new components.Values();
        functions.Category category = new functions.Category();
        functions.Question question = new functions.Question();

        public frmAddQuestion()
        {
            InitializeComponent();
        }

        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            category.LoadCategoryChoices(cboCategory);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtQuestion.Text))
            {
                if (question.AddQuestion(txtQuestion.Text, int.Parse(cboCategory.SelectedValue.ToString())))
                {
                    MessageBox.Show("Question saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Question field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
