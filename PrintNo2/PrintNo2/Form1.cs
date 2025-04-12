using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintNo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (int no in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(no)) 
                {
                    listBox2.Items.Add(no);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

       

      

        
    }
}
