using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3_Talk
{
    class Talk
    {
        public static int ActualTalk(string wordsToSay, int times)
        {
            string finalWords = "";
            for (int i = 0; i < times; i++)
            {
                finalWords += wordsToSay + "\n";
            }
            MessageBox.Show(finalWords);
            return finalWords.Length;
        }
    }
}
