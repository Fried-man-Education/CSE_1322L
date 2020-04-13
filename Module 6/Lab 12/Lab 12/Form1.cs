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

namespace Lab_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // Save
        {
            string path = Directory.GetCurrentDirectory() + "\\" + textBox1.Text;
            if (textBox1.Text == "")
            {
                textBox1.Text = "Empty path name is not legal.";
            }
            else
            {
                string content = textBox2.Text;
                FileStream saveFile = File.Create(path);
                saveFile.Write(new UTF8Encoding(true).GetBytes(content), 0, content.Length);
                saveFile.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) // Load
        {
            string path = Directory.GetCurrentDirectory() + "\\" + textBox1.Text;
            path = path.Replace("\\","/");
            if (textBox1.Text == "") {
                textBox1.Text = "Empty path name is not legal.";
            } else if (!File.Exists(path) || textBox1.Text.Count(c => c == '.') == 0)
            {
                textBox1.Text = "Could not find file \"" + path + "\".";
            } else
            {
                textBox2.Text = File.ReadAllText(path, Encoding.UTF8);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
