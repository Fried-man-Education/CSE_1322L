using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        int boxValue1, boxValue2;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            boxValue2 = int.Parse(textBox2.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "The value is " + (boxValue1 + boxValue2);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            boxValue1 = int.Parse(textBox1.Text);
        }
    }
}
