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
    public partial class login : MetroForm
    {
        public login()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (verify_login_frontend(metroTextBox1.Text.Trim(), metroTextBox2.Text.Trim()) == true)
                {
                    this.Hide();
                    frontend hotel_management = new frontend();
                    hotel_management.Show();
                }
                else if (verify_login_kitchen(metroTextBox1.Text.Trim(), metroTextBox2.Text.Trim()) == true)
                {
                    this.Hide();
                    kitchen kitchen_management = new kitchen();
                    kitchen_management.Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }


        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

            if (metroTextBox1.Text == string.Empty)
            {
                metroLabel1.Visible = true;
            }
            if (metroTextBox1.Text != "Username" && metroTextBox1.Text != string.Empty)
            {
                metroLabel1.Visible = false;
            }
        }
        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text == string.Empty)
            {
                metroLabel2.Visible = true;
            }
            if (metroTextBox2.Text != "Password" && metroTextBox2.Text != string.Empty)
            {
                metroLabel2.Visible = false;
            }
        }
   
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!metroLabel1.Bounds.Contains(e.Location) && metroTextBox1.Text == string.Empty)
            {
                metroLabel1.Visible = false;
            }
            if (!metroLabel2.Bounds.Contains(e.Location) && metroTextBox2.Text == string.Empty)
            {
                metroLabel2.Visible = false;
            }

        }

        //verifier
        public bool verify_login_frontend(string username, string password)
        {

            bool success = false;
            string sql = "SELECT* FROM  frontend WHERE user_name=@userName AND pass_word=@password";
            try
            {
                SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.loginConnectionString);
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.CommandText = sql;
                SqlParameter UsernameParametar = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter PassParametar = new SqlParameter("@password", SqlDbType.VarChar);
                sqlCommand.Parameters.Add(UsernameParametar);
                sqlCommand.Parameters.Add(PassParametar);
                UsernameParametar.Value = username;
                PassParametar.Value = password;
                connection.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                if (sqlReader.HasRows)
                    success = true;
                connection.Close();
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return success;
        }
        public bool verify_login_kitchen(string username, string password)
        {

            bool success = false;
            string sql = "SELECT* FROM  kitchen WHERE user_name=@userName AND pass_word=@password";
            try
            {
                SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.loginConnectionString);
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.CommandText = sql;
                SqlParameter UsernameParametar = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter PassParametar = new SqlParameter("@password", SqlDbType.VarChar);
                sqlCommand.Parameters.Add(UsernameParametar);
                sqlCommand.Parameters.Add(PassParametar);
                UsernameParametar.Value = username;
                PassParametar.Value = password;
                connection.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                if (sqlReader.HasRows)
                    success = true;
                connection.Close();
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return success;
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            License open_license = new License();
            open_license.ShowDialog();
        }
    }
}
