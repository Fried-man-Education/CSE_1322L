using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            label1.Text = new DataTable().Compute(label1.Text, null).ToString();
        }
    }
}
