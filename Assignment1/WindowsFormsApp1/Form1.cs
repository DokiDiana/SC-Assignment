using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void Add(object sender, EventArgs e)
        {
            result = Double.Parse(textBox1.Text) + Double.Parse(textBox2.Text);
        }

        private void Sub(object sender, EventArgs e)
        {
            result = Double.Parse(textBox1.Text) - Double.Parse(textBox2.Text);
        }

        private void Mul(object sender, EventArgs e)
        {
            result = Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text);
        }

        private void div(object sender, EventArgs e)
        {
            if (Double.Parse(textBox2.Text) == 0)
                textBox2.Text = "Error!Please input an correct number!";
            else
                result = Double.Parse(textBox1.Text) / Double.Parse(textBox2.Text);
        }

        private void Result(object sender, EventArgs e)
        {
            textBox3.Text = result.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
