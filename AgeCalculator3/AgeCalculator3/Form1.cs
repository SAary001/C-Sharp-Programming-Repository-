using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgeCalculator3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
                comboBox1.Items.Add(i);


            for (int i = 1; i <= 12; i++)
                comboBox2.Items.Add(i);


            for (int i = 1950; i <= 2024; i++)
                comboBox3.Items.Add(i);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select day, month and year.");
                return;
            }

            int day = Convert.ToInt32(comboBox1.SelectedItem);
            int month = Convert.ToInt32(comboBox2.SelectedItem);
            int year = Convert.ToInt32(comboBox3.SelectedItem);

            AgeCalculater ageCalc = new AgeCalculater(day, month, year);
            string result = ageCalc.CalculateAge();

            textBox1.Text = result;
        }

        

     
    }
}
