using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snooker1.Models
{
    public class Match
    {
        
        public DateTime Date { get; set; }

        public List<Player> Players { get; set; }

        public List<Frame> Frames { get; set; }

        public int FramesWon { get; set; }

        public int FramesLost { get; set; }

        private bool win;

        public bool MatchResultWin
        {
            get { return win; }
            set { win =  matchWon( FramesWon); }
        }



        private bool matchWon (int frames)
        {
            if (FramesWon > 2)
            {
                return true;
            }
            return false;
        }



    }
}