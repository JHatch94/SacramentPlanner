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

        public Hymn OpeningHymn { get; set; }

        public Hymn SacramentHymn { get; set; }

        public Hymn ClosingHymn { get; set; }

        public string OpeningPrayer { get; set; }

        public string ClosingPrayer { get; set; }



    }
}
