using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Information_Management_Finals_Generator.functions
{
    class Query
    {
        components.Connection con = new components.Connection();
        components.Values val = new components.Values();

        public bool ExecuteQuery(string sql, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        grid.DataSource = dt;
                        return true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.ToString());
                val.ErrorMessage = error.ToString();
                return false;
            }
        }
    }
}
