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

        private void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (verify_login_frontend(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()) == true)
                {
                    this.Hide();
                    frontend hotel_management = new frontend();
                    hotel_management.Show();
                }
                else if (verify_login_kitchen(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()) == true)
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

        private void usernameTextBox_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!usernameLabel.Bounds.Contains(e.Location) && usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = false;
            }
            if (!passwordLabel.Bounds.Contains(e.Location) && passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = false;
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

        private void LicenseCallButton_Click(object sender, EventArgs e)
        {
            License open_license = new License();
            open_license.ShowDialog();
        }


    }
}
