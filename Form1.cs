using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string celyText = "";
            for(int i =0;i<textBox1.Lines.Length;i++) 
            {
                string radek = textBox1.Lines[i].ToString();
                radek =radek.Trim();
                int j = 0;
               while(j<radek.Length-1) 
                {
                    if (radek[j] == ' ' && radek[j + 1] == ' ')
                    {
                        radek =radek.Remove(j+1, 1);
                    }
                    else j++;
                }
                if(!radek.EndsWith(".")) radek += ".";
                radek = char.ToUpper(radek[0]) + radek.Substring(1);
                celyText += radek + "\r\n";
            }
            textBox1.Text = celyText;
        }
    }
}
