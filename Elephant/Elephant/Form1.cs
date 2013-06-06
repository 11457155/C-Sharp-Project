using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elephant
{
    public partial class Form1 : Form
    {
        Elephant lioyd;
        Elephant lucinda;
        Elephant temp;
        public Form1()
        {
            InitializeComponent();

            lioyd = new Elephant(){ earSize = 20, name = "lioyd"};
            lucinda = new Elephant() { earSize = 30, name = "lucinda"};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lioyd.whoAmI());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lucinda.whoAmI());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = lioyd;
            lioyd = lucinda;
            MessageBox.Show("Objects swapped");
            lucinda = temp;
        }
    }
}
