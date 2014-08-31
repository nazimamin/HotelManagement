using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hotel_Manager
{
    public partial class kitchen : MetroForm
    {
        public kitchen()
        {
            InitializeComponent();

        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nazim\documents\visual studio 2013\Projects\Hotel_Manager\Hotel_Manager\frontend_reservation.mdf;Integrated Security=True");
        private void kitchen_Load(object sender, EventArgs e)
        {
            LoadForDataGridView();
            listBoxFromDataBase();
        }

        private void kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        string cleaning, towel, surprise;
        int breakfast, lunch, dinner, foodBill;
        public Int32 primaryID;
        double totalBill;
        bool supply_status = false;

        private void LoadForDataGridView()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

                SqlCommand query = new SqlCommand("Select ID, first_name, last_name, phone_number, room_type, room_floor, room_number, break_fast, lunch, dinner, cleaning, towel, s_surprise, supply_status, food_bill from reservation where check_in = '" + "True" + "' AND supply_status= '" + "False" + "'", connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dataGridView1.DataSource = bindingSource;
                    dataAdapter.Update(dataTable);
                    connection.Close();
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
        private void resetEntries()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                        func(control.Controls);
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
                    }
                }
            };

            func(Controls);

        }
        private void listBoxFromDataBase()
        {

            listBox1.Items.Clear();
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

                string query = "Select * from reservation where check_in = '" + "True" + "' AND supply_status='" + "False" + "'";

                SqlCommand query_table = new SqlCommand(query, connection);
                SqlDataReader reader;
                try
                {
                    connection.Open();
                    reader = query_table.ExecuteReader();
                    while (reader.Read())
                    {
                        string ID = reader["ID"].ToString();
                        string first_name = reader["first_name"].ToString();
                        string last_name = reader["last_name"].ToString();
                        string phone_number = reader["phone_number"].ToString();
                        listBox1.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();
                resetEntries();
                string getQuerystring = listBox1.Text.Substring(0, 4).Replace(" ", string.Empty);
                //MessageBox.Show("ID+" + getQuerystring);
                string query = "Select * from reservation where Id= '" + getQuerystring + "'";

                SqlCommand query_table = new SqlCommand(query, connection);
                SqlDataReader reader;
                try
                {
                    connection.Open();
                    reader = query_table.ExecuteReader();
                    while (reader.Read())
                    {
                        string ID = reader["Id"].ToString();
                        string first_name = reader["first_name"].ToString();
                        string last_name = reader["last_name"].ToString();
                        string phone_number = reader["phone_number"].ToString();
                        string foodBillD = reader["food_bill"].ToString();
                        string total_bill = reader["total_bill"].ToString().Replace(" ", string.Empty);
                        string room_type = reader["room_type"].ToString();
                        string room_floor = reader["room_floor"].ToString();
                        string room_number = reader["room_number"].ToString();

                        string _cleaning = reader["cleaning"].ToString();
                        string _towel = reader["towel"].ToString();
                        string _surprise = reader["s_surprise"].ToString();



                        if (_cleaning == "True")
                        {
                            cleaning = "1";
                            metroCheckBox4.Checked = true;
                        }
                        else { cleaning = "0"; }

                        if (_towel == "True")
                        {
                            towel = "1";
                            metroCheckBox5.Checked = true;
                        }
                        else { towel = "0"; }
                        if (_surprise == "True")
                        {
                            surprise = "1";
                            metroCheckBox3.Checked = true;
                        }
                        else
                        {
                            surprise = "0";
                        }

                        string supply_status = reader["supply_status"].ToString();
                        string food_billD = reader["food_bill"].ToString();

                        string _breakfast = reader["break_fast"].ToString();
                        string _lunch = reader["lunch"].ToString();
                        string _dinner = reader["dinner"].ToString();

                        double Num;
                        bool isNum = double.TryParse(_lunch, out Num);
                        if (isNum)
                        {
                            lunch = Int32.Parse(_lunch);
                            metroTextBox8.Text = Convert.ToString(lunch);
                        }
                        else
                        {
                            lunch = 0;
                            metroTextBox8.Text = "NONE";
                        }
                        isNum = double.TryParse(_breakfast, out Num);
                        if (isNum)
                        {
                            breakfast = Int32.Parse(_breakfast);
                            metroTextBox7.Text = Convert.ToString(breakfast);
                        }
                        else
                        {
                            breakfast = 0;
                            metroTextBox7.Text = "NONE";
                        }
                        isNum = double.TryParse(_dinner, out Num);
                        if (isNum)
                        {
                            dinner = Int32.Parse(_dinner);
                            metroTextBox9.Text = Convert.ToString(dinner);
                        }
                        else
                        {
                            dinner = 0;
                            metroTextBox9.Text = "NONE";
                        }

                        if (supply_status == "True")
                        {
                            metroCheckBox2.Checked = true;
                        }
                        else
                        {
                            metroCheckBox2.Checked = false;
                        }

                        metroTextBox1.Text = first_name;
                        metroTextBox2.Text = last_name;
                        metroTextBox3.Text = phone_number;
                        metroTextBox4.Text = room_type;
                        metroTextBox6.Text = room_floor;
                        metroTextBox5.Text = room_number;
                        totalBill = Convert.ToDouble(total_bill);
                        foodBill = Convert.ToInt32(foodBillD);
                        totalBill -= foodBill;
                        primaryID = Convert.ToInt32(ID);

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            food_menu.metroPanel2.Visible = false;

            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            int bfast= 0, Lnch= 0, di_ner = 0;
            if (breakfast > 0)
            {
                bfast = 7 * breakfast;
            } if (lunch > 0)
            {
                Lnch = 15 * lunch;
            } if (dinner > 0)
            {
                di_ner = 15 * dinner;
            }
            foodBill += (bfast + Lnch + di_ner);
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

                if (primaryID > 1000)
                {
                    string query = "update reservation set total_bill='" + totalBill + foodBill + "', break_fast='" + breakfast + "', lunch= '" + lunch + "', dinner='" + dinner + "', supply_status='" + supply_status + "',cleaning='" + Convert.ToInt32(cleaning) + "',towel='" + Convert.ToInt32(towel) + "',s_surprise='" + Convert.ToInt32(surprise) + "',food_bill='" + foodBill + "' WHERE Id = '" + primaryID + "';";

                    SqlCommand query_table = new SqlCommand(query, connection);
                    SqlDataReader reader;
                    try
                    {
                        connection.Open();
                        string userID = Convert.ToString(primaryID);
                        reader = query_table.ExecuteReader();

                        MetroFramework.MetroMessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                        " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        while (reader.Read())
                        {

                        }
                        connection.Close();
                        listBoxFromDataBase();
                        LoadForDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            metroCheckBox4.Checked = false;
            metroCheckBox4.Text = "Cleaned";
            metroCheckBox5.Checked = false;
            metroCheckBox5.Text = "Toweled";
            metroCheckBox3.Checked = false;
            metroCheckBox3.Text = "Surprised";
            supply_status = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
