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
    public partial class frmQuestions : Form
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Question question = new functions.Question();
        functions.Category category = new functions.Category();
        int random_number;
        int time = 1;

        public frmQuestions()
        {
            InitializeComponent();
        }

        private void frmQuestions_Load(object sender, EventArgs e)
        {
            question.LoadQuestions(dtgQuestions);
            category.LoadCategoryChoices(cboCategory);
            question.FilterQuestionByCategory(int.Parse(cboCategory.SelectedValue.ToString()), true, dtgQuestions);
        }

        private void cboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            question.FilterQuestionByCategory(int.Parse(cboCategory.SelectedValue.ToString()), true, dtgQuestions);
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                Random rnd = new Random();
                random_number = rnd.Next(0, dtgQuestions.Rows.Count - 1);

                val.Question = (string)dtgQuestions[1, random_number].Value;
                lblQuestion.Text = val.Question;
                input.frmInput input_form = new input.frmInput();
                input_form.FormClosing += new FormClosingEventHandler(this.frmQuestion_FormClosing);
                input_form.ShowDialog();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time < dtgQuestions.Rows.Count - 1)
            {
                time = time + 1;
                lblQuestion.Text = (string)dtgQuestions[1, time].Value;
            }
            else
            {
                time = 0;
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frmQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
