using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name = "";
        private void button6_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            MessageBox.Show(name.Substring(2,3));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            MessageBox.Show(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            MessageBox.Show(name.ToUpper());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            MessageBox.Show(name.ToLower());
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            name = textBox1.Text;
            MessageBox.Show(name.Trim());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            bool b = name.Contains(textBox1.Text);
            if (b == true)
            {
                MessageBox.Show("exists");
            }
            else
            {
                MessageBox.Show("not exists");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
           // string nam=textBox1.Text;
            MessageBox.Show(name.Replace(name,name));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string[] arr = name.Split(',');

            foreach (string c in arr)
            {
                MessageBox.Show(c);
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
              name = textBox1.Text;
            int c = name.Count();
            MessageBox.Show(c.ToString());
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            name=textBox1.Text;
            
            foreach(char c in name)
            {
                MessageBox.Show(c.ToString());
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
           name= name.ToLower();
            char[]c=name.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o' || c[i] == 'u')
                {
                    MessageBox.Show(c[i].ToString());
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
           string n1=textBox1.Text;
            string num = textBox1.Text;
            MessageBox.Show(string.Concat(n1,num));

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        StringBuilder sb=new StringBuilder();
        private void button13_Click(object sender, EventArgs e)
        {
            name= textBox2.Text;
              sb.Append(name);
            label2.Text=sb.ToString();
            textBox2.Clear();
            textBox1.Focus();
            //MessageBox.Show(sb.ToString());

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string em=string.Empty;

          string  txt = textBox2.Text;
            if (!string.IsNullOrEmpty(txt))
            {
                MessageBox.Show("string not Empty");
            }
            else
            {
                MessageBox.Show("stringEmpty");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // string em = string.Empty;
            //em = "";
            string nm = textBox2.Text;
            if (!string.IsNullOrWhiteSpace(nm))
            {
                MessageBox.Show("string not empty");
            }
            else
            {
                MessageBox.Show("stringEmpty");
            }
        }
    }
}
