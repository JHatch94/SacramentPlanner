using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        public Meeting Meeting { get; set; }
        public int MeetingId { get; set; }
        [Display(Name="Speaker Name")]
        public String SpeakerName { get; set; }
        public String Topic { get; set; }
    }
}

