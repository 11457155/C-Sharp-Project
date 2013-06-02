using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3_Talk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = Talk.ActualTalk(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("The message length of this is: " + size);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
