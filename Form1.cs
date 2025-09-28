using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLL;
namespace WindowsForms__28_9_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            string result = Class1.ToBugLanguage(input);
            txtResult.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
