using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        public int MeetingId { get; set; }
        public String SpeakerName { get; set; }
        public String Topic { get; set; }
    }
}
