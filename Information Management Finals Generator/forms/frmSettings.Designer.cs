namespace Information_Management_Finals_Generator.forms
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dtgCategories = new System.Windows.Forms.DataGridView();
            this.tabQuestions = new System.Windows.Forms.TabPage();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.dtgQuestions = new System.Windows.Forms.DataGridView();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategories)).BeginInit();
            this.tabQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuestions)).BeginInit();
            this.grpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCategories);
            this.tabControl1.Controls.Add(this.tabQuestions);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCategories
            // 
            this.tabCategories.Controls.Add(this.lblName);
            this.tabCategories.Controls.Add(this.label3);
            this.tabCategories.Controls.Add(this.lblID);
            this.tabCategories.Controls.Add(this.label2);
            this.tabCategories.Controls.Add(this.btnUpdateCategory);
            this.tabCategories.Controls.Add(this.btnAddCategory);
            this.tabCategories.Controls.Add(this.dtgCategories);
            this.tabCategories.Location = new System.Drawing.Point(4, 29);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.Size = new System.Drawing.Size(982, 406);
            this.tabCategories.TabIndex = 0;
            this.tabCategories.Text = "Categories";
            this.tabCategories.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(366, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(19, 20);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(366, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 20);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID:";
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(875, 363);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(101, 37);
            this.btnUpdateCategory.TabIndex = 9;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(768, 363);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(101, 37);
            this.btnAddCategory.TabIndex = 8;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dtgCategories
            // 
            this.dtgCategories.AllowUserToAddRows = false;
            this.dtgCategories.AllowUserToDeleteRows = false;
            this.dtgCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgCategories.Location = new System.Drawing.Point(3, 3);
            this.dtgCategories.Name = "dtgCategories";
            this.dtgCategories.ReadOnly = true;
            this.dtgCategories.Size = new System.Drawing.Size(296, 400);
            this.dtgCategories.TabIndex = 0;
            this.dtgCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategories_CellClick);
            // 
            // tabQuestions
            // 
            this.tabQuestions.Controls.Add(this.txtKeyword);
            this.tabQuestions.Controls.Add(this.dtgQuestions);
            this.tabQuestions.Controls.Add(this.grpQuestion);
            this.tabQuestions.Location = new System.Drawing.Point(4, 29);
            this.tabQuestions.Name = "tabQuestions";
            this.tabQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestions.Size = new System.Drawing.Size(982, 406);
            this.tabQuestions.TabIndex = 1;
            this.tabQuestions.Text = "Questions";
            this.tabQuestions.UseVisualStyleBackColor = true;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(339, 35);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(295, 26);
            this.txtKeyword.TabIndex = 5;
            // 
            // dtgQuestions
            // 
            this.dtgQuestions.AllowUserToAddRows = false;
            this.dtgQuestions.AllowUserToDeleteRows = false;
            this.dtgQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQuestions.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgQuestions.Location = new System.Drawing.Point(3, 3);
            this.dtgQuestions.Name = "dtgQuestions";
            this.dtgQuestions.ReadOnly = true;
            this.dtgQuestions.Size = new System.Drawing.Size(330, 400);
            this.dtgQuestions.TabIndex = 3;
            this.dtgQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgQuestions_CellClick);
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.btnUpdateQuestion);
            this.grpQuestion.Controls.Add(this.btnAddQuestion);
            this.grpQuestion.Controls.Add(this.lblIsActive);
            this.grpQuestion.Controls.Add(this.label4);
            this.grpQuestion.Controls.Add(this.lblCategory);
            this.grpQuestion.Controls.Add(this.label1);
            this.grpQuestion.Controls.Add(this.lblQuestion);
            this.grpQuestion.Controls.Add(this.label5);
            this.grpQuestion.Location = new System.Drawing.Point(339, 58);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(637, 342);
            this.grpQuestion.TabIndex = 4;
            this.grpQuestion.TabStop = false;
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.Location = new System.Drawing.Point(530, 299);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(101, 37);
            this.btnUpdateQuestion.TabIndex = 7;
            this.btnUpdateQuestion.Text = "Update";
            this.btnUpdateQuestion.UseVisualStyleBackColor = true;
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(423, 299);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(101, 37);
            this.btnAddQuestion.TabIndex = 6;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(89, 54);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(19, 20);
            this.lblIsActive.TabIndex = 5;
            this.lblIsActive.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Active:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(89, 22);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(19, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(89, 85);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(542, 203);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Question:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 463);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategories)).EndInit();
            this.tabQuestions.ResumeLayout(false);
            this.tabQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuestions)).EndInit();
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.DataGridView dtgCategories;
        private System.Windows.Forms.TabPage tabQuestions;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridView dtgQuestions;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Button btnUpdateQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label5;
    }
}