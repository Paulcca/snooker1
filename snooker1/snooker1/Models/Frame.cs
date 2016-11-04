using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snooker1.Models
{
    public class Frame
    {
        public int ID { get; set; }
        
        public Player Player { get; set; }

        public bool FrameWon { get; set; }


    }
}