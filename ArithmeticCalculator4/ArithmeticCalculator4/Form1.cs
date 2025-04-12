using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArithmeticCalculator4
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

            float ans=0;

            if (checkBox1.Checked)
                ans += (no1 + no2);

            if (checkBox2.Checked)
                ans += (no1 - no2);

            if (checkBox3.Checked)
                ans += (no1 * no2);

            if (checkBox4.Checked)
            {
                if (no2 == 0)
                {
                    MessageBox.Show("Can not divide by 0");
                    return;
                }
                ans += (float)no1 / no2;
            }

            label3.Text = ans.ToString();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits (0-9) are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits (0-9) are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
