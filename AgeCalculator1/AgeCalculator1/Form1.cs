﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgeCalculator1
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

           
            for (int i = 1950; i <= 2025; i++)
                comboBox3.Items.Add(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select day, month and year.");
                return;
            }

            int birthDay = Convert.ToInt32(comboBox1.SelectedItem);
            int birthMonth = Convert.ToInt32(comboBox2.SelectedItem);
            int birthYear = Convert.ToInt32(comboBox3.SelectedItem);


            int currentDay = DateTime.Now.Day;//used the DateTime class 
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;


            int age = currentYear - birthYear;

            if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay))
            {
                age--;
            }

            textBox1.Text = "Your age is: " + age.ToString();
        }

       

       
    }
}
