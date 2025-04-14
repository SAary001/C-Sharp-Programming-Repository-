using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarksCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4;
            n1 = Convert.ToInt32(textBox5.Text);
            n2 = Convert.ToInt32(textBox6.Text);
            n3 = Convert.ToInt32(textBox7.Text);
            n4 = Convert.ToInt32(textBox8.Text);
            

            textBox9.Text = (n1 + n2 + n3 + n4).ToString();


            string sname = textBox1.Text;
            string cname = textBox2.Text;
            long prnno = long.Parse(textBox3.Text);
            long phono = long.Parse(textBox4.Text);


            textBox10.Text = "Your name is :" + sname.ToString() + " Your college is :" + cname.ToString() + " Your PRN no is :" + prnno.ToString() + " Your Phone is :" + phono.ToString();

            float percentage = (n1 + n2 + n3 + n4) / 4.0f;
            textBox11.Text = percentage.ToString("0.00") + "%";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Invalid Input");
               
            }

            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Invalid Input");
                
            }
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Invalid Input");

            }
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Invalid Input");

            }
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("invalid input");
                e.Cancel = true;

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("invalid input");
                e.Cancel = true;

            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("invalid input");
                e.Cancel = true;

            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("invalid input");
                e.Cancel = true;

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }
       
    }
}
