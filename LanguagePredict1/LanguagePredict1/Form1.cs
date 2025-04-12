using System;
using System.Windows.Forms;

namespace LanguagePredict1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "You know: ";
            bool knowsAny = false;

            if (checkBox1.Checked)
            {
                result += "Marathi, ";
                knowsAny = true;
            }
            if (checkBox2.Checked)
            {
                result += "English, ";
                knowsAny = true;
            }
            if (checkBox3.Checked)
            {
                result += "Hindi, ";
                knowsAny = true;
            }
            if (checkBox4.Checked)
            {
                result += "German, ";
                knowsAny = true;
            }

            if (knowsAny)
            {
                
                result = result.TrimEnd(',', ' ');
                textBox1.Text = result;
            }
            else
            {
                textBox1.Text = "You don't know any language.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            
            textBox1.Clear();
        
        }

        
        
    }
}
