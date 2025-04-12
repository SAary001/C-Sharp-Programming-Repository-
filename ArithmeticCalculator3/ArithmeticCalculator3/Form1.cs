using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArithmeticCalculator3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(textBox1.Text);
            int no2 = Convert.ToInt32(textBox2.Text);

            float res = 0;

            //string ops = comboBox1.SelectedIndex.ToString();
            string ops = comboBox1.SelectedItem.ToString();
            switch (ops)
            {
                case "Addition":
                {
                    res = no1 + no2;
                    break;
                }
                case "Subtraction ":
                {
                    if (no1 > no2)
                        res = no1 - no2;
                    else
                        res = no2 - no1;
                    break;
                }
                case "Multiplication ":
                {
                    res = no1 * no2;
                    break;
                }
                case "Division":
                {
                    if (no2 == 0)
                    {
                        MessageBox.Show("Can not divide by 0");
                        return;
                    }
                    res = (float) no1 / no2;
                    break;
                }
                case "Modulo ":
                {
                    if (no2 == 0)
                    {
                        MessageBox.Show("Can not divide by 0");
                        return;
                    }
                    int ans = no1 / no2;
                    res = no1 - (no2*ans);
                    break;
                }
                default:
                MessageBox.Show("Please select an operation");
                return;
            }
            label3.Text = res.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "Result is ";
        }
    }
}
