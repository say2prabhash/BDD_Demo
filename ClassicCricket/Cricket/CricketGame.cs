using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    public class CricketGame
    {
        public int TotalScore { get; set; }
        public bool Finished { get; set; }
        public CricketGame()
        {
            Finished = false;
        }
        public void Score(int runs)
        {
            if(runs>=0 && Finished==false)
            {
                TotalScore += runs;
            }
            if(runs<0)
            {
                Finished = true;
            }
        }
    }
}
