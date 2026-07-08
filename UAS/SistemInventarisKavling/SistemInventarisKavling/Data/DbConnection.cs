using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInventarisKavling.Data
{
    internal class DbConnection
    {
        private readonly string connStr =
            "server=localhost;database=db_kavling;uid=root;pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
