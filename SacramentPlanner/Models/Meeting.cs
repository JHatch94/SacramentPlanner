using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public DateTime Date { get; set; }
        public Speaker Speaker { get; set; }
        public Bishopric Presiding { get; set; }

        public string OpeningHymn { get; set; }

        public string SacramentHymn { get; set; }

        public string ClosingHymn { get; set; }

        public string OpeningPrayer { get; set; }

        public string ClosingPrayer { get; set; }



    }
}
