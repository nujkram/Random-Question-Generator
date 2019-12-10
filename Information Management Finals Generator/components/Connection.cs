using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Information_Management_Finals_Generator.components
{
    class Connection
    {
        public string conString = String.Format("datasource={0};username={1};password={2}",
            Values.server_address, Values.server_username, Values.server_password);
    }
}
