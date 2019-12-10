using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Information_Management_Finals_Generator.forms
{
    public partial class frmSettings : Form
    {
        components.Values val = new components.Values();
        functions.Category category = new functions.Category();
        functions.Question question = new functions.Question();

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            category.LoadCategories(dtgCategories);
            question.LoadQuestions(dtgQuestions);
            SetCategoryDetail();
        }


        private void dtgCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCategoryDetail();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            categories.frmAddCategory add_category = new categories.frmAddCategory();
            add_category.ShowDialog();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dtgQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetQuestionDetail();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            questions.frmAddQuestion add_question = new questions.frmAddQuestion();
            add_question.ShowDialog();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {

        }

        private void SetCategoryDetail()
        {
            val.CategoryID = (int)dtgCategories[0, dtgCategories.CurrentRow.Index].Value;
            val.CategoryName = (string)dtgCategories[1, dtgCategories.CurrentRow.Index].Value;

            lblID.Text = val.CategoryID.ToString();
            lblName.Text = val.CategoryName;
        }

        private void SetQuestionDetail()
        {
            val.QuestionID = (int)dtgQuestions[0, dtgQuestions.CurrentRow.Index].Value;
            val.Question = (string)dtgQuestions[1, dtgQuestions.CurrentRow.Index].Value;
            val.CategoryName = (string)dtgQuestions[2, dtgQuestions.CurrentRow.Index].Value;
            val.QuestionActive = (bool)dtgQuestions[3, dtgQuestions.CurrentRow.Index].Value;

            lblQuestion.Text = val.Question;
            lblCategory.Text = val.CategoryName;
            lblIsActive.Text = val.QuestionActive.ToString();
        }
    }
}
