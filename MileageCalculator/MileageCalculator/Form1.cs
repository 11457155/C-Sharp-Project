using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate;
        double ownedMoney;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("the starting mileage miles must be larger than the ending mileage miles");
            }
            else if (numericUpDown1.Value == numericUpDown2.Value)
            {
                MessageBox.Show("the car is not used");
            }
            else
            {
                startingMileage = (int)numericUpDown1.Value;
                endingMileage = (int)numericUpDown2.Value;
                reimburseRate = Convert.ToDouble(textBox1.Text);

                milesTraveled = endingMileage -= startingMileage;
                ownedMoney = milesTraveled *= reimburseRate;

                label4.Text = "$" + ownedMoney;
            }
        }
    }
}
