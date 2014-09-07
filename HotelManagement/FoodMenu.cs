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
    public partial class FoodMenu : MetroForm
    {


        public FoodMenu()
        {
            InitializeComponent();
        }

        private int lunchQ = 0;

        public int LunchQ
        {
            get { return lunchQ; }
            set { lunchQ = value; }
        }
        private int breakfastQ = 0;

        public int BreakfastQ
        {
            get { return breakfastQ; }
            set { breakfastQ = value; }
        }
        private int dinnerQ = 0;

        public int DinnerQ
        {
            get { return dinnerQ; }
            set { dinnerQ = value; }
        }

        private string cleaning= "";

        public string Cleaning
        {
            get { return cleaning; }
            set { cleaning = value; }
        }
        private string towel = "";

        public string Towel
        {
            get { return towel; }
            set { towel = value; }
        }
  
        private string surprise = "";

        public string Surprise
        {
            get { return surprise; }
            set { surprise = value; }
        }
      
        private void FoodMenu_Load(object sender, EventArgs e)
        {
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                BreakfastQ = Convert.ToInt32(metroTextBox1.Text);
            }
            if (metroCheckBox2.Checked)
            {
                LunchQ = Convert.ToInt32(metroTextBox2.Text);
            }
            if (metroCheckBox3.Checked)
            {
                DinnerQ = Convert.ToInt32(metroTextBox3.Text);
            }
            if (metroCheckBox4.Checked)
            {
                Cleaning = metroCheckBox4.Text;
            } if (metroCheckBox5.Checked)
            {
                Towel = metroCheckBox5.Text;
            } 
            if (metroCheckBox7.Checked)
            {
                Surprise = metroCheckBox7.Text;
            }
            
            this.Hide();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                metroTextBox1.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked)
            {
                metroTextBox2.Enabled = true;
            }
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox3.Checked)
            {
                metroTextBox3.Enabled = true;
            }
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FoodMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FoodMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

    
    }
}
