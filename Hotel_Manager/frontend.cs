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
using System.Configuration;
using Twilio;
namespace Hotel_Manager
{
    public partial class frontend : MetroForm
    {
        string AccountSid = "Twilio Account Sid";
        string AuthToken = "TwilioAuthToken";
        string RecvPhoneNumber = "";
        public frontend()
        {
            InitializeComponent();
            CenterToScreen();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(1);

            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();

            this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox2.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox2_DrawItem);
        }



        private void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(listBox1.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }
        private void listBox2_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.listBox2.IntegralHeight = false;
            this.listBox2.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(listBox2.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }


        private string getval;

        public string Getval
        {
            get { return getval; }
            set { getval = value; }
        }

        public string towelS, cleaningS, surpriseS;

        public int foodBill;
        public string birthday = "";

        public string food_menu = "";
        public int totalAmount = 0;
        public int checkin = 0;
        public int foodStatus = 0;
        public Int32 primartyID = 0;
        public Boolean taskFinder = false;
        public Boolean editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private double finalizedTotalAmount = 0.0;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private string cleaning; private string towel;
        private string surprise;

        private void MainTab_Load(object sender, EventArgs e)
        {
            metroCheckBox2.Enabled = false;
           
        }
        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
        public void metroButton6_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    food_menu.metroCheckBox1.Checked = true;
                    food_menu.metroTextBox1.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    food_menu.metroCheckBox2.Checked = true;

                    food_menu.metroTextBox2.Text = Convert.ToString(lunch);
                }
                if (dinner > 0)
                {
                    food_menu.metroCheckBox3.Checked = true;
                    food_menu.metroTextBox3.Text = Convert.ToString(dinner);
                }
                if (cleaning == "1")
                {
                    food_menu.metroCheckBox4.Checked = true;
                }
                if (towel == "1")
                {
                    food_menu.metroCheckBox5.Checked = true;
                }
                if (surprise == "1")
                {
                    food_menu.metroCheckBox7.Checked = true;
                }
            }
            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            cleaning = food_menu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? "1" : "0";
            towel = food_menu.Towel.Replace(" ", string.Empty) == "Towels" ? "1" : "0";

            surprise = food_menu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? "1" : "0";

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }
        }
     
        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (metroComboBox5.SelectedItem.Equals("Single"))
            {
                totalAmount = 149;
                metroComboBox6.SelectedItem = "1";
            }
            else if (metroComboBox5.SelectedItem.Equals("Double"))
            {
                totalAmount = 299;
                metroComboBox6.SelectedItem = "2";
            }
            else if (metroComboBox5.SelectedItem.Equals("Twin"))
            {
                totalAmount = 349;
                metroComboBox6.SelectedItem = "3";
            }
            else if (metroComboBox5.SelectedItem.Equals("Duplex"))
            {
                totalAmount = 399;
                metroComboBox6.SelectedItem = "4";
            }
            else if (metroComboBox5.SelectedItem.Equals("Suite"))
            {
                totalAmount = 499;
                metroComboBox6.SelectedItem = "5";
            }
            int selectedTemp = 0;
            string selected;
            bool temp = int.TryParse(metroComboBox10.SelectedItem.ToString(), out selectedTemp);
            if (!temp)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = metroComboBox10.SelectedItem.ToString();
                selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            editClicked = true;
            dateTimePicker1.MinDate = new DateTime(2014, 4, 1);
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.MinDate = new DateTime(2014, 4, 1);
            dateTimePicker2.CustomFormat = "MM-dd-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            metroButton1.Visible = false;
            metroButton3.Visible = true;
            metroButton7.Visible = true;
            metroComboBox8.Visible = true;

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
        }

        
        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == "0" && towel == "0" && surprise == "0")
            {
                metroCheckBox2.Checked = true;
            }
            metroButton3.Enabled = true;

            FinalizePayment finalizebil = new FinalizePayment();
            finalizebil.totalAmountFromFrontend = totalAmount;
            finalizebil.foodBill = foodBill;
            if (taskFinder)
            {
                finalizebil.metroComboBox12.SelectedItem = FPayment.Replace(" ", string.Empty);
                finalizebil.metroTextBox10.Text = FCnumber;
                finalizebil.metroComboBox1.SelectedItem = FcardExpOne;
                finalizebil.metroComboBox2.SelectedItem = FcardExpTwo;
                finalizebil.metroTextBox1.Text = FCardCVC;
            }

            finalizebil.ShowDialog();

            finalizedTotalAmount = finalizebil.FinalTotalFinalized;
            paymentType = finalizebil.PaymentType;
            paymentCardNumber = finalizebil.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil.MM_YY_Of_Card1;
            CVC_Of_Card = finalizebil.CVC_Of_Card1;
            CardType = finalizebil.CardType1;

            if (!editClicked)
            {
                metroButton1.Visible = true;
            }
        }

        private void SendSMS(int secondUserID)
        {
            //creating an instance of twilio rest
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            string name = metroTextBox1.Text + " " + metroTextBox2.Text;

            string end_num = paymentCardNumber.Substring(paymentCardNumber.Length - Math.Min(4, paymentCardNumber.Length));

            if (metroCheckBox3.Checked)
            {
                //building message for twilio
                string buildMesage = "Hello " + name + "! Your unique ID# " + secondUserID + " Total bill of $" + finalizedTotalAmount + " is charged on your card # ending-" + end_num;
                //creating message 
                var message = twilio.SendMessage("+12034562736", RecvPhoneNumber, buildMesage, "");
                //sending message
                Console.WriteLine(message.Sid);
                metroCheckBox3.Text = "SMS Sent";
            }
        }
      
        private void metroButton1_Click(object sender, EventArgs e)
        {
            birthday = (metroComboBox1.SelectedItem) + "-" + (metroComboBox2.SelectedIndex + 1) + "-" + metroTextBox4.Text;
            Int32 getIDBack = 0;
            string query = "insert into reservation(first_name, last_name, birth_day, gender, phone_number, email_address, number_guest, street_address, apt_suite,city, state, zip_code, room_type, room_floor, room_number, total_bill,payment_type, card_type, card_number,card_exp,card_cvc, arrival_time, leaving_time, check_in, break_fast, lunch, dinner, supply_status, cleaning, towel, s_surprise, food_bill) values('" + metroTextBox1.Text +
              "', '" + metroTextBox2.Text + "', '" + birthday + "', '" + metroComboBox3.SelectedItem + "', '" + metroTextBox3.Text + "', '" + metroTextBox5.Text +
              "', '" + (metroComboBox10.SelectedIndex + 1) + "', '" + metroTextBox6.Text + "', '" + metroTextBox7.Text + "', '" + metroTextBox8.Text +
              "', '" + metroComboBox4.SelectedItem + "', '" + metroTextBox9.Text + "', '" + metroComboBox5.SelectedItem + "', '" + metroComboBox6.SelectedItem +
              "', '" + metroComboBox7.SelectedItem + "', '" + finalizedTotalAmount + "', '" + paymentType +
              "', '" + CardType + "','" + paymentCardNumber + "','" + MM_YY_Of_Card + "','" + CVC_Of_Card + "', '" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "','" + checkin +
              "', '" + breakfast + "','" + lunch + "','" + dinner + "', '" + foodStatus + "', '" + Convert.ToInt32(cleaning) + "', '" + Convert.ToInt32(towel) + "', '" + Convert.ToInt32(surprise) + "','" + foodBill + "');";
            query += "SELECT CAST(scope_identity() AS int)";
            SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

            SqlCommand query_table = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                getIDBack = (Int32)query_table.ExecuteScalar();

                string userID = Convert.ToString(getIDBack);
                SendSMS(getIDBack);
                MetroFramework.MetroMessageBox.Show(this, "Entry successfully inserted into database. " + "\n\n" +
                    "Provide this unique ID to the customer." + "\n\n" +
                "USER UNIQUE ID: " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            metroButton1.Visible = false;
            metroButton3.Visible = false;
            metroButton7.Visible = false;
            metroComboBox8.Visible = false;
            reset_frontend();
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
        public void ClearAllComboBox(Control controls){
            foreach(Control control in controls.Controls){
                if (control == metroComboBox5)
                {
                    continue;
                }
                else if(control is ComboBox){
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren) {
                    ClearAllComboBox(control);
                }
            }
        }
        private void reset_frontend()
        {
            try
            {

                metroComboBox8.Items.Clear();
                metroCheckBox1.Checked = false;
                metroCheckBox2.Checked = false;

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);

                ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                metroCheckBox1.Text = "Checked in";
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (primartyID > 1000)
            {
                string query = "delete from reservation where Id = '" + primartyID + "'";
                SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

                SqlCommand query_table = new SqlCommand(query, connection);
                SqlDataReader reader;
                try
                {
                    connection.Open();
                    reader = query_table.ExecuteReader();

                    MetroFramework.MetroMessageBox.Show(this, "Reservation For the UNIQUE USER ID of: " + "\n\n" +
                " " + primartyID + " is DELETED.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    connection.Close();

                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist." + ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            birthday = (metroComboBox1.SelectedItem) + "-" + (metroComboBox2.SelectedIndex + 1) + "-" + metroTextBox4.Text;
           // MessageBox.Show(Convert.ToString(cleaning) + " " + Convert.ToString(towel) + " " + Convert.ToString(surprise));
            string query = "update reservation set first_name ='" + metroTextBox1.Text +
              "', last_name ='" + metroTextBox2.Text + "', birth_day='" + birthday + "', gender='" + metroComboBox3.SelectedItem + "', phone_number='" + metroTextBox3.Text + "', email_address='" + metroTextBox5.Text +
              "', number_guest='" + (metroComboBox10.SelectedIndex + 1) + "', street_address='" + metroTextBox6.Text + "', apt_suite='" + metroTextBox7.Text + "', city='" + metroTextBox8.Text +
              "', state='" + metroComboBox4.SelectedItem + "', zip_code='" + metroTextBox9.Text + "', room_type='" + metroComboBox5.SelectedItem + "', room_floor='" + metroComboBox6.SelectedItem +
              "', room_number='" + metroComboBox7.SelectedItem + "', total_bill='" + finalizedTotalAmount + "', payment_type='" + paymentType +
              "', card_type ='" + CardType + "', card_number='" + paymentCardNumber + "',card_exp='" + MM_YY_Of_Card + "', card_cvc='" + CVC_Of_Card + "', arrival_time='" + dateTimePicker1.Text + "', leaving_time='" + dateTimePicker2.Text + "', break_fast='" + breakfast +
              "', check_in='" + checkin + "', lunch='" + lunch + "', dinner='" + dinner + "', supply_status='" + foodStatus + "',cleaning='" + Convert.ToInt32(cleaning) + "',towel='" + Convert.ToInt32(towel) + "',s_surprise='" + Convert.ToInt32(surprise) + "',food_bill='" + foodBill + "' WHERE Id = '" + primartyID + "';";

           // SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\frontend_reservation.mdf;Integrated Security=True");

            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                string userID = Convert.ToString(primartyID);
                reader = query_table.ExecuteReader();

                MetroFramework.MetroMessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                SendSMS(primartyID);
                while (reader.Read())
                {

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();

            reset_frontend();
            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void metroCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                metroCheckBox1.Text = "Checked in";
                checkin = 1;
            }
            else
            {
                checkin = 0;
                metroCheckBox1.Text = "Check in ?";
            }
        }

        private void metroComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            getChecked();
            string getQuerystring = metroComboBox8.Text.Substring(0, 4).Replace(" ", string.Empty);
          //  MessageBox.Show("ID+" + getQuerystring);
            string query = "Select * from reservation where Id= '" + getQuerystring + "'";

            SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = query_table.ExecuteReader();
                while (reader.Read())
                {
                    taskFinder = true;
                    string ID = reader["Id"].ToString();
                    string first_name = reader["first_name"].ToString();
                    string last_name = reader["last_name"].ToString();
                    string birth_day = reader["birth_day"].ToString();
                    string gender = reader["gender"].ToString();
                    string phone_number = reader["phone_number"].ToString();
                    string email_address = reader["email_address"].ToString();
                    string number_guest = reader["number_guest"].ToString();
                    string street_address = reader["street_address"].ToString();
                    string apt_suite = reader["apt_suite"].ToString();
                    string city = reader["city"].ToString();
                    string state = reader["state"].ToString();
                    string zip_code = reader["zip_code"].ToString();

                    string room_type = reader["room_type"].ToString();
                    string room_floor = reader["room_floor"].ToString();
                    string room_number = reader["room_number"].ToString();

                    string payment_type = reader["payment_type"].ToString();
                    string card_number = reader["card_number"].ToString();
                    string card_exp = reader["card_exp"].ToString();
                    string card_cvc = reader["card_cvc"].ToString();

                    string _cleaning = reader["cleaning"].ToString();
                    string _towel = reader["towel"].ToString();
                    string _surprise = reader["s_surprise"].ToString();
                    if (_cleaning == "True")
                    {
                        cleaning = "1";
                    }
                    else { cleaning = "0"; }

                    if (_towel == "True")
                    {
                        towel = "1";
                    }
                    else { towel = "0"; }
                    if (_surprise == "True")
                    {
                        surprise = "1";
                    }
                    else
                    {
                        surprise = "0";
                    }
                    metroComboBox7.Items.Add(room_number);
                    metroComboBox7.SelectedItem = room_number;

                    FPayment = payment_type; FCnumber = card_number;
                    FCardCVC = card_cvc; FcardExpOne = card_exp.Substring(0, card_exp.IndexOf('/'));
                    FcardExpTwo = card_exp.Substring(card_exp.Length - Math.Min(2, card_exp.Length));
                    string check_in = reader["check_in"].ToString();

                    string supply_status = reader["supply_status"].ToString();
                    string food_billD = reader["food_bill"].ToString();

                    string arrival_date = Convert.ToDateTime(reader["arrival_time"]).ToString("MM-dd-yyyy").Replace(" ", string.Empty);
                    dateTimePicker1.Value = Convert.ToDateTime(arrival_date);

                    string leaving_date = Convert.ToDateTime(reader["leaving_time"]).ToString("MM-dd-yyyy").Replace(" ", string.Empty);
                    dateTimePicker2.Value = Convert.ToDateTime(leaving_date);
                    dateTimePicker1.Value.ToShortDateString();
                    dateTimePicker2.Value.ToShortDateString();

                    string _breakfast = reader["break_fast"].ToString();
                    string _lunch = reader["lunch"].ToString();
                    string _dinner = reader["dinner"].ToString();

                    double Num;
                    bool isNum = double.TryParse(_lunch, out Num);
                    if (isNum)
                    {
                        lunch = Int32.Parse(_lunch);
                    }
                    else
                    {
                        lunch = 0;
                    }
                    isNum = double.TryParse(_breakfast, out Num);
                    if (isNum)
                    {
                        breakfast = Int32.Parse(_breakfast);
                    }
                    else
                    {
                        breakfast = 0;
                    }
                    isNum = double.TryParse(_dinner, out Num);
                    if (isNum)
                    {
                        dinner = Int32.Parse(_dinner);
                    }
                    else
                    {
                        dinner = 0;
                    }



                    foodBill = Convert.ToInt32(food_billD);

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
                    metroComboBox3.SelectedItem = gender;

                    metroComboBox1.SelectedItem = birth_day.Substring(0, birth_day.IndexOf('-'));
                    metroComboBox2.SelectedItem = birth_day.Substring(birth_day.IndexOf('-') + 1, 2);
                    metroTextBox4.Text = birth_day.Substring(birth_day.Length - Math.Min(4, birth_day.Length));

                    metroTextBox5.Text = email_address;
                    metroComboBox10.SelectedItem = number_guest;
                    metroTextBox6.Text = street_address;
                    metroTextBox7.Text = apt_suite;
                    metroTextBox8.Text = city;
                    metroComboBox4.SelectedItem = state;
                    metroTextBox9.Text = zip_code;
                    metroComboBox5.SelectedItem = room_type.Replace(" ", string.Empty);
                    metroComboBox6.SelectedItem = room_floor.Replace(" ", string.Empty);
                    metroComboBox7.SelectedItem = room_number.Replace(" ", string.Empty);

                    if (check_in == "True")
                    {
                        metroCheckBox1.Checked = true;
                    }
                    else
                    {
                        metroCheckBox1.Checked = false;
                    }


                    primartyID = Convert.ToInt32(ID);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
        }

        private void ComboBoxItemsFromDataBase()
        {
            string query = "Select * from reservation";
            //SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\frontend_reservation.mdf;Integrated Security=True");

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
                    metroComboBox8.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadForDataGridView()
        {
            SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            SqlCommand query = new SqlCommand("Select * from reservation", connection);
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

        private void metroButton8_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked)
            {
                metroCheckBox2.Text = "Food/Supply: Complete";
                foodStatus = 1;
            }
            else
            {
                foodStatus = 0;
                metroCheckBox2.Text = "Food/Supply status?";
            }
        }

        private void GetOccupiedRoom()
        {
            listBox1.Items.Clear();
            string query = "Select * from reservation where check_in = '" + "True" + "';";
            SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = query_table.ExecuteReader();
                while (reader.Read())
                {
                    string room_number = reader["room_number"].ToString();
                    string room_type = reader["room_type"].ToString();
                    string ID = reader["ID"].ToString();
                    string first_name = reader["first_name"].ToString();
                    string last_name = reader["last_name"].ToString();
                    string phone_number = reader["phone_number"].ToString();
                    string arrival_time = reader["arrival_time"].ToString();
                    string dep_time = reader["leaving_time"].ToString();
                    listBox1.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                        " " + room_type.Replace(" ", string.Empty) +
                        " " + ID.Replace(" ", string.Empty) +
                        " " + "[" + first_name.Replace(" ", string.Empty) +
                        " " + last_name.Replace(" ", string.Empty) + "]" +
                        " " + phone_number.Replace(" ", string.Empty));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ReservedRoom()
        {
            listBox2.Items.Clear();

            string query = "Select * from reservation where check_in = '" + "False" + "';";
            SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = query_table.ExecuteReader();
                while (reader.Read())
                {
                    string room_number = reader["room_number"].ToString();
                    string room_type = reader["room_type"].ToString();
                    string ID = reader["ID"].ToString();
                    string first_name = reader["first_name"].ToString();
                    string last_name = reader["last_name"].ToString();
                    string phone_number = reader["phone_number"].ToString();

                    string arrival_date = Convert.ToDateTime(reader["arrival_time"]).ToString("MM-dd-yyyy");
                    string leaving_date = Convert.ToDateTime(reader["leaving_time"]).ToString("MM-dd-yyy");

                    listBox2.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                        " " + room_type.Replace(" ", string.Empty) +
                        " " + ID.Replace(" ", string.Empty) +
                        " " + first_name.Replace(" ", string.Empty) +
                        " " + last_name.Replace(" ", string.Empty) +
                        " " + phone_number.Replace(" ", string.Empty) +
                        " " + arrival_date.Replace(" ", string.Empty) +
                        " " + leaving_date.Replace(" ", string.Empty));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

        private void getChecked()
        {
            List<string> TakenRoomList = new List<string>();

            string query = "Select room_number from reservation where check_in = '" + "True" + "';";
            SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

            SqlCommand query_table = new SqlCommand(query, connection);

            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = query_table.ExecuteReader();
                while (reader.Read())
                {
                    string room_number = reader["room_number"].ToString();
                    TakenRoomList.Add(room_number.Replace(" ", string.Empty));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (string roomList in TakenRoomList)
            {
                if (metroComboBox7.Items.Contains(roomList))
                {

                    int temp = metroComboBox7.Items.IndexOf(roomList);
                    metroComboBox7.Items.RemoveAt(temp);
                }
            }
        }

        private void metroTextBox3_Leave(object sender, EventArgs e)
        {
            RecvPhoneNumber = "+1"+metroTextBox3.Text.Replace(" ", string.Empty);
            long getphn = Convert.ToInt64(metroTextBox3.Text);
            string formatString = String.Format("{0:(000)000-0000}", getphn);
            metroTextBox3.Text = formatString;
        }
        private void bindingData()
            
        {

            SqlConnection con = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            con.Open();
            string query = "Select * from reservation where Id like '%" + metroTextBox10.Text + "%' OR last_name like '%" + metroTextBox10.Text + "%' OR first_name like '%" + metroTextBox10.Text + "%' OR gender like '%" + metroTextBox10.Text + "%' OR state like '%" + metroTextBox10.Text + "%' OR city like '%" + metroTextBox10.Text + "%' OR room_number like '%" + metroTextBox10.Text + "%' OR room_type like '%" + metroTextBox10.Text + "%' OR email_address like '%" + metroTextBox10.Text + "%' OR phone_number like '%" + metroTextBox10.Text + "%'";
           
            SqlDataAdapter data_adapter = new SqlDataAdapter(query, con);
            DataTable data_table = new DataTable();
            data_adapter.Fill(data_table);
            
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = data_table;
            dataGridView2.DataSource = bindingSource;
            data_adapter.Update(data_table);
        }

        private void metroButton8_Click_1(object sender, EventArgs e)
        {
          SqlConnection con = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            
            con.Open();
            string query = "Select * from reservation where Id like '%" + metroTextBox10.Text + "%' OR last_name like '%" + metroTextBox10.Text + "%' OR first_name like '%" + metroTextBox10.Text + "%' OR gender like '%" + metroTextBox10.Text + "%' OR state like '%" + metroTextBox10.Text + "%' OR city like '%" + metroTextBox10.Text + "%' OR room_number like '%" + metroTextBox10.Text + "%' OR room_type like '%" + metroTextBox10.Text + "%' OR email_address like '%" + metroTextBox10.Text + "%' OR phone_number like '%" + metroTextBox10.Text + "%'";
           
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader reader;
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                bindingData();
                metroButton8.Location = new Point(752, 7);
                metroTextBox10.Location = new Point(68, 7);
                dataGridView2.Visible = true;
                SearchError.Visible = false;
            }
            else
            {
                dataGridView2.Visible = false;
                SearchError.Visible = true;
                SearchError.Text = "SORRY DUDE :(" +"\n"
                    +"I ran out of gas trying to search for "+ metroTextBox10.Text +"\n"
                +"I sure will find it next time."; 
            }
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
