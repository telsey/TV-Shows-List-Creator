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

namespace Text_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            String name_of_show = textBox1.Text;
            String season = textBox2.Text;
            int s = Int32.Parse(season);
            String episodes = textBox3.Text;
            int ep = Int32.Parse(episodes);
            dostuff(name_of_show, s, ep);
        }


        private void dostuff(string name_of_show, int season, int episodes)
        {
           
            string a;
            string sez;
            string epi;
            StreamWriter File = new StreamWriter("List.txt");  //Name of txt file or destination ("C://***/List.txt")

            for (int i=1;i<=season;i++)
            {
                if (i < 10)
                    sez = "0" + i;
                else
                    sez = "" + i;

                for(int j=1;j<=episodes;j++)
                {
                    if (j < 10)
                        epi = "0" + j;
                    else
                        epi = "" + j;
                        

                    a = name_of_show + " " + "S" + sez + "E" + epi + " - ";
                    File.Write(a+"\r\n");
                }
                File.Write("\r\n");
            }
            File.Close();
            MessageBox.Show("It has been done!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//Only numbers in TextBox  + backspace
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            if (char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)//Only numbers in TextBox + backspace 
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            if (char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e) //TextBox1 check if empty
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //TextBox2 check if empty
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //TextBox3 check if empty
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
    }
}
