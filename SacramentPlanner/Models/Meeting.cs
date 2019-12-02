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

        public int HymnNumber { get; set; }
        public string HymnName { get; set; }

        public string Presiding { get; set; }

    }
}
