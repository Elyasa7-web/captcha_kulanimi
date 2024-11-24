using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha_kulanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };
            string[] sembol4 = { "&", "=", "!", "_", ">", "<", "|" };
            string[] sembol5 = { "A", "B", "C", "D", "E", "F", "G", "J", "K", "L", "M" };


            Random r = new Random();
            int s1, s2, s3, s4, s5, s6;
            s1 = r.Next(0,sembol1.Length);
            s2 = r.Next(0,sembol2.Length);
            s3 = r.Next(0, 10);
            s4 = r.Next(0, sembol4.Length);
            s5 =r.Next(0, sembol5.Length);
            s6 = r.Next(0, 20);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString() + sembol4[s4].ToString() + sembol5[s5].ToString() + s6.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
