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

       
    }
}
