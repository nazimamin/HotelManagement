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
    public partial class Kitchen : MetroForm
    {
        string cleaning, towel, surprise, queryString;
        int breakfast, lunch, dinner, foodBill;
        public Int32 primaryID;
        double totalBill;
        bool supply_status = false;

        SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
        SqlCommand query;
        SqlDataReader reader;
        
        public Kitchen()
        {
            InitializeComponent();

        }
        private void kitchen_Load(object sender, EventArgs e)
        {
            LoadForDataGridView();
            listBoxFromDataBase();
        }

        private void LoadForDataGridView()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

                queryString = "Select ID, first_name, last_name, phone_number, room_type, room_floor, room_number, break_fast, lunch, dinner, cleaning, towel, s_surprise, supply_status, food_bill from reservation where check_in = '" + "True" + "' AND supply_status= '" + "False" + "'";
                query = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    overviewDataGridView.DataSource = bindingSource;
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

        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    resetEntries(control);
                }
            }

        }
        private void listBoxFromDataBase()
        {

            queueListBox.Items.Clear();
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

                queryString = "Select * from reservation where check_in = '" + "True" + "' AND supply_status='" + "False" + "'";

                query = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        string ID = reader["ID"].ToString();
                        string first_name = reader["first_name"].ToString();
                        string last_name = reader["last_name"].ToString();
                        string phone_number = reader["phone_number"].ToString();
                        queueListBox.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);

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

        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();
                resetEntries(this);
                string getQuerystring = queueListBox.Text.Substring(0, 4).Replace(" ", string.Empty);
                //MessageBox.Show("ID+" + getQuerystring);
                queryString = "Select * from reservation where Id= '" + getQuerystring + "'";
                
                query = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    reader = query.ExecuteReader();
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
                            cleaningCheckBox.Checked = true;
                        }
                        else { cleaning = "0"; }

                        if (_towel == "True")
                        {
                            towel = "1";
                            towelCheckBox.Checked = true;
                        }
                        else { towel = "0"; }
                        if (_surprise == "True")
                        {
                            surprise = "1";
                            surpriseCheckBox.Checked = true;
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
                            lunchTextBox.Text = Convert.ToString(lunch);
                        }
                        else
                        {
                            lunch = 0;
                            lunchTextBox.Text = "NONE";
                        }
                        isNum = double.TryParse(_breakfast, out Num);
                        if (isNum)
                        {
                            breakfast = Int32.Parse(_breakfast);
                            breakfastTextBox.Text = Convert.ToString(breakfast);
                        }
                        else
                        {
                            breakfast = 0;
                            breakfastTextBox.Text = "NONE";
                        }
                        isNum = double.TryParse(_dinner, out Num);
                        if (isNum)
                        {
                            dinner = Int32.Parse(_dinner);
                            dinnerTextBox.Text = Convert.ToString(dinner);
                        }
                        else
                        {
                            dinner = 0;
                            dinnerTextBox.Text = "NONE";
                        }

                        if (supply_status == "True")
                        {
                            supplyCheckBox.Checked = true;
                        }
                        else
                        {
                            supplyCheckBox.Checked = false;
                        }

                        firstNameTextBox.Text = first_name;
                        lastNameTextBox.Text = last_name;
                        phoneNTextBox.Text = phone_number;
                        roomTypeTextBox.Text = room_type;
                        floorNTextBox.Text = room_floor;
                        roomNTextBox.Text = room_number;
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

        private void foodSelectionButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            food_menu.needPanel.Visible = false;

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

                if (primaryID > 1000)
                {
                    queryString = "update reservation set total_bill='" + totalBill + foodBill + "', break_fast='" + breakfast + "', lunch= '" + lunch + "', dinner='" + dinner + "', supply_status='" + supply_status + "',cleaning='" + Convert.ToInt32(cleaning) + "',towel='" + Convert.ToInt32(towel) + "',s_surprise='" + Convert.ToInt32(surprise) + "',food_bill='" + foodBill + "' WHERE Id = '" + primaryID + "';";

                    query = new SqlCommand(queryString, connection);
                    try
                    {
                        connection.Open();
                        string userID = Convert.ToString(primaryID);
                        reader = query.ExecuteReader();

                        MetroFramework.MetroMessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                        " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        connection.Close();
                        listBoxFromDataBase();
                        LoadForDataGridView();
                        resetEntries(this);
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

        private void supplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cleaningCheckBox.Checked = false;
            cleaningCheckBox.Text = "Cleaned";
            towelCheckBox.Checked = false;
            towelCheckBox.Text = "Toweled";
            surpriseCheckBox.Checked = false;
            surpriseCheckBox.Text = "Surprised";
            supply_status = true;
        }
        private void kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
