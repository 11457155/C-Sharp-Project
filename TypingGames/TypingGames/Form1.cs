using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TypingGames
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));

            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over!");
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             /* if the user presses a key down, if this key is in the listbox, then remove it from the
             listbox, and update the statusStrip value accordingly, and then make this game a little bit
             faster */

            if(listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                
                /* code to make this game a little bit faster */
                if (timer1.Interval > 400)
                {
                    timer1.Interval -= 20;
                }
                else if (timer1.Interval > 250)
                {
                    timer1.Interval -= 10;
                }
                else if (timer1.Interval > 100)
                {
                    timer1.Interval -= 5;
                }

                DifficultyProgressBar.Value = 800 - timer1.Interval;

                stats.update(true);

            }
            else
            {
                stats.update(false);
            }

            /* code used to update the StatusStrip value */
            CorrectLabel.Text = "Correct: " + stats.correct;
            MissedLabel.Text = "Missed: " + stats.missed;
            TotalLabel.Text = "Total: " + stats.total;
            AccuracyLabel.Text = "Accuracy: " + stats.accuracy;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /* if the user presses a key down, if this key is in the listbox, then remove it from the
             listbox, and update the statusStrip value accordingly, and then make this game a little bit
             faster */

            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();

                /* code to make this game a little bit faster */
                if (timer1.Interval > 400)
                {
                    timer1.Interval -= 10;
                }
                else if (timer1.Interval > 250)
                {
                    timer1.Interval -= 5;
                }
                else if (timer1.Interval > 100)
                {
                    timer1.Interval -= 2;
                }
                else if (timer1.Interval > 2)
                {
                    timer1.Interval -= 1;
                }

                if (800 - timer1.Interval > 100)
                {
                    DifficultyProgressBar.Value = 100;
                }
                else
                {
                    DifficultyProgressBar.Value = 800 - timer1.Interval;
                }

                stats.update(true);

            }
            else
            {
                stats.update(false);
            }

            /* code used to update the StatusStrip value */
            CorrectLabel.Text = "Correct: " + stats.correct;
            MissedLabel.Text = "Missed: " + stats.missed;
            TotalLabel.Text = "Total: " + stats.total;
            AccuracyLabel.Text = "Accuracy: " + stats.accuracy;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
