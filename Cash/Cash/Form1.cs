using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cash
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { name = "joe", cash = 100 };
            bob = new Guy() { name = "bob", cash = 100 };

            updateTheForm();
        }

        public void updateTheForm()
        {
            joeCashLabel.Text = joe.name + " has $ " + joe.cash;
            bobsCashLabel.Text = bob.name + " has $ " + bob.cash;
            banksCashLabel.Text = " the bank  has $ " + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (bank >= 10)
            {
                bank -= joe.receiveCash(10);
                updateTheForm();
            }
            else
            {
                MessageBox.Show("there is no enough money in the bank.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.giveCash(5);
            updateTheForm();
        }

        private void joeGiveBob_Click(object sender, EventArgs e)
        {
            int giveMoney = joe.giveCash(10);
            bob.receiveCash(giveMoney);
            updateTheForm();
        }

        private void bobGiveJohn_Click(object sender, EventArgs e)
        {
            joe.receiveCash(bob.giveCash(5));
            updateTheForm();
        }


    }
}
