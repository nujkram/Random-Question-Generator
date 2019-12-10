using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Information_Management_Finals_Generator.functions
{
    class Question
    {
        components.Connection con = new components.Connection();
        components.Values val = new components.Values();

        public void LoadQuestions(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString))
                {
                    string sql = @"SELECT q.id, q.question, c.name, q.is_active 
                                FROM cc5_db.questions q, cc5_db.category c 
                                WHERE c.id = q.category_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.Columns[0].Visible = false;
                        grid.Columns[1].HeaderText = "Question";
                        grid.Columns[2].HeaderText = "Category";
                        grid.Columns[3].HeaderText = "Active";

                        if (dt.Rows.Count != 0)
                        {
                            val.QuestionID = dt.Rows[0].Field<int>("id");
                            val.Question = dt.Rows[0].Field<string>("question");
                            val.CategoryName = dt.Rows[0].Field<string>("name");
                            val.QuestionActive = dt.Rows[0].Field<bool>("is_active");

                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
            }
        }

        public bool AddQuestion(string question, int category_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString))
                {
                    string sql = @"INSERT INTO cc5_db.questions(question, category_id) VALUES(@question, @category_id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@question", question);
                        cmd.Parameters.AddWithValue("@category_id", category_id);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        
                        return true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
                Console.WriteLine(category_id.ToString());
                return false;
            }
        }

        public void FilterQuestionByCategory(int category_id, bool is_active, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString))
                {
                    string sql = @"SELECT * FROM cc5_db.questions WHERE category_id = @category_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@category_id", category_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
            }
        }
    }
}
