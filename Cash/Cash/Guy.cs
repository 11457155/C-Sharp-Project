using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cash
{
    class Guy
    {
        public string name;
        public int cash;

        public int receiveCash(int amount)
        {
            if (amount > 0)
            {
                cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " bucks are not the money I will receive ", name + " says ");
                return 0;
            }
        }

        public int giveCash(int amount)
        {
            if (amount > 0 && amount <= cash)
            {
                cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " bucks are beyond my capability ", name + " says ");
                return 0;
            }
        }
    }
}
