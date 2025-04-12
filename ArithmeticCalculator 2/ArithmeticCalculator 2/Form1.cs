using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArithmeticCalculator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no1=Convert.ToInt32(textBox1.Text);
            int no2=Convert.ToInt32(textBox2.Text);
            float result = 0;


            if (radioButton1.Checked)
                result = no1 + no2;
            else if (radioButton2.Checked)
            {
                 result = no1 - no2;
               // else if (no1 < no2) result = no2 - no1;
            }
            else if (radioButton3.Checked)
                result = no1 * no2;
            else if (radioButton4.Checked)
            {
                if (no2 == 0)
                {
                    MessageBox.Show("Can not divide by 0");
                    return;
                }
                result = (float)no1 / no2;
            }
            else if (radioButton5.Checked)
            { 
                
                if (no2 == 0)
                {
                    MessageBox.Show("Can not divide by 0");
                    return;
                }
                int ans = no1 / no2;
                result = no1 - (no2 * ans);
            }
            label3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "Result is ";
        }

       
    }
}
