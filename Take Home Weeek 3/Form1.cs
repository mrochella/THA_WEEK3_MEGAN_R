using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_Weeek_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butt_submit_Click(object sender, EventArgs e)
        {
            int ageBerapa = Convert.ToInt32(textBox_age.Text);
            if (ageBerapa >= 18)
            {
                MessageBox.Show("Name: " + textBox_name.Text + "\nEmail: " + textBox_email.Text + "\nPhone Number: " + textBox_phoneNum.Text + "\nYou are an adult :)");
            }
            else
            {
                MessageBox.Show("Name: " + textBox_name.Text + "\nEmail: " + textBox_email.Text + "\nPhone Number: " + textBox_phoneNum.Text + "\nYou are a minor :(");
            }
        }

        private void butt_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_age.Clear();
            textBox_email.Clear();
            textBox_phoneNum.Clear();
        }
    }
}
