using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Manager
{
    class AutoDB
    {
        SqlConnection connection;
        public AutoDB()
        {
            connection = new SqlConnection();
        }
        public void AutoDBLogin(string query)
        {
            connection.ConnectionString = Hotel_Manager.Properties.Settings.Default.loginConnectionString;
            SqlCommand queryT = new SqlCommand(query, connection);
        }
        public void AutoDBLoginOpen()
        {
            connection.Open();
        }
        public void AutoDBLoginClose()
        {
            connection.Close();
        }
    }
}
