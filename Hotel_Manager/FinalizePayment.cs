using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Hotel_Manager
{
    public partial class FinalizePayment : MetroForm
    {
        public FinalizePayment()
        {
            InitializeComponent();
            CenterToParent();
            
        }
        public int totalAmountFromFrontend = 0;
        private double finalTotalFinalized = 0.0;
        public int foodBill = 0;
        public double FinalTotalFinalized
        {
            get { return finalTotalFinalized; }
            set { finalTotalFinalized = value; }
        }

        private string paymentType;

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        private string paymentCardNumber;

        public string PaymentCardNumber
        {
            get { return paymentCardNumber; }
            set { paymentCardNumber = value; }
        }
        private string MM_YY_Of_Card;

        public string MM_YY_Of_Card1
        {
            get { return MM_YY_Of_Card; }
            set { MM_YY_Of_Card = value; }
        }
        private string CVC_Of_Card;

        public string CVC_Of_Card1
        {
            get { return CVC_Of_Card; }
            set { CVC_Of_Card = value; }
        }
        private string CardType;

        public string CardType1
        {
            get { return CardType; }
            set { CardType = value; }
        }

        private void FinalizePayment_Load(object sender, EventArgs e)
        {
         
            double totalWithTax = Convert.ToDouble(totalAmountFromFrontend) * 0.07; 
            double FinalTotal = Convert.ToDouble(totalAmountFromFrontend) + totalWithTax + foodBill;
            metroLabel2.Text = "$" + Convert.ToString(totalAmountFromFrontend)+" USD";
            metroLabel14.Text = "$" + Convert.ToString(foodBill) + " USD";
            metroLabel6.Text = "$" + Convert.ToString(totalWithTax)+" USD";
            metroLabel9.Text = "$" + Convert.ToString(FinalTotal) + " USD";
            FinalTotalFinalized = FinalTotal;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {   

            try
            {
                PaymentType = metroComboBox12.Text;
                PaymentCardNumber = metroTextBox10.Text;
                MM_YY_Of_Card1 = metroComboBox1.SelectedItem.ToString() +"/"+ metroComboBox2.SelectedItem.ToString();
                CVC_Of_Card1 = metroTextBox1.Text;
                CardType1 = metroLabel11.Text;
                
                this.Hide();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error Closing the window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalizePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
         
        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void metroTextBox10_Click(object sender, EventArgs e)
        {
         
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTextBox10.Text.Substring(0, 1) == "3")
            {
                metroLabel11.Text = "AmericanExpress";
            }
            else if (metroTextBox10.Text.Substring(0, 1) == "4")
            {
                metroLabel11.Text = "Visa";
            }
            else if (metroTextBox10.Text.Substring(0, 1) == "5")
            {
                metroLabel11.Text = "MasterCard";
            }
            else if (metroTextBox10.Text.Substring(0, 1) == "6")
            {
                metroLabel11.Text = "Discover";
            }
            else
                metroLabel11.Text = "Unknown";
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox10_Leave(object sender, EventArgs e)
        {
            long getphn = Convert.ToInt64(metroTextBox10.Text);
            string formatString = String.Format("{0:0000-0000-0000-0000}", getphn);
            metroTextBox10.Text = formatString;
        }
       
    }
}
