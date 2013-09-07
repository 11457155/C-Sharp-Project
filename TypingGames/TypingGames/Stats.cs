using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypingGames
{
    class Stats
    {
        public int correct = 0;
        public int missed = 0;
        public int total = 0;
        public int accuracy = 0;

        public void update(bool correctKey)
        {
            /* no matter if this key is right or wrong, total number shall always increase */
            total++;
            if (correctKey == true)
            {
                correct++;
            }
            else
            {
                missed++;
            }

            accuracy = correct * 100 / (correct + missed);
        }
    }
}
