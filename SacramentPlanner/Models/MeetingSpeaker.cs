using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class MeetingSpeaker
    {
        public int MeetingSpeakerId { get; set; }
        public Meeting meeting { get; set; }
        public int MeetingId { get; set; }
        public Speaker speaker { get; set; }
        public int SpeakerId { get; set; }
    }
}
