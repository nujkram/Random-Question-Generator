using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Information_Management_Finals_Generator.components
{
    class Values
    {
        public static string server_address = "localhost";
        public static string server_username = "root";
        public static string server_password = "admin";

        // <category data>
        public static int category_id;
        public static string category_name;

        public int CategoryID
        {
            get { return category_id; }
            set { category_id = value; }
        }

        public string CategoryName
        {
            get { return category_name; }
            set { category_name = value; }
        }
        // </category data>

        // <question data>
        public static int question_id;
        public static string question;
        public static int question_category;
        public static bool question_is_active;

        public int QuestionID
        {
            get { return question_id; }
            set { question_id = value; }
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public int QuestionCategory
        {
            get { return question_category; }
            set { question_category = value; }
        }

        public bool QuestionActive
        {
            get { return question_is_active; }
            set { question_is_active = value; }
        }
        // </question data>

        public static string error_message;

        public string ErrorMessage
        {
            get { return error_message; }
            set { error_message = value; }
        }
    }
}
