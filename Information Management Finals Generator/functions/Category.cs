using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Information_Management_Finals_Generator.functions
{
    class Category
    {
        components.Connection con = new components.Connection();
        components.Values val = new components.Values();

        public void LoadCategories(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString))
                {
                    string sql = @"SELECT * FROM cc5_db.category";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns[0].HeaderText = "ID";
                        grid.Columns[1].HeaderText = "Name";

                        if (dt.Rows.Count != 0)
                        {
                            val.CategoryID = dt.Rows[0].Field<int>("id");
                            val.CategoryName = dt.Rows[0].Field<string>("name");
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
            }
        }

        public void LoadCategoryChoices(ComboBox combo_box)
        {
            using (MySqlConnection connection = new MySqlConnection(con.conString))
            {
                string sql = @"SELECT * FROM cc5_db.category";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    if (dt.Rows.Count > 0)
                    {
                        combo_box.ValueMember = "id";
                        combo_box.DisplayMember = "name";
                        combo_box.DataSource = dt;
                    }
                }
            }
        }

        public bool AddCategory(string name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString))
                {
                    string sql = @"INSERT INTO cc5_db.category(name) VALUES(@name);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);

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
                return false;
            }
        }
    }
}
