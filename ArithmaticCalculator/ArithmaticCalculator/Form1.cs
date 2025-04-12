using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArithmaticCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a number in TextBox 1");
                e.Cancel = true; // Keeps the focus in textBox1
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a number in TextBox 2");
                e.Cancel = true; // Keeps the focus in textBox1   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(textBox1.Text);
            int no2 = Convert.ToInt32(textBox2.Text);
            int ans = no1 + no2;
            textBoxResult.Text =  ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(textBox1.Text); 
            int no2 = Convert.ToInt32(textBox2.Text);
            if (no1 > no2)
            {
                int ans = no1 - no2;
                textBoxResult.Text =  ans.ToString();
            }
            else
            {
                int ans = no2 - no1;
                textBoxResult.Text =  ans.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(textBox1.Text);
            int no2 = Convert.ToInt32(textBox2.Text);
            int ans = no1 * no2;
            textBoxResult.Text =  ans.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(textBox1.Text);
            int no2 = Convert.ToInt32(textBox2.Text);
            if (no2 == 0)
            {
                MessageBox.Show("Number can not be divided by 0");
                return;
            }
            float ans =(float) no1 / no2;
            textBoxResult.Text = ans.ToString();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBoxResult.Clear();
        }

      
      
     

        
        
       
    }
}
