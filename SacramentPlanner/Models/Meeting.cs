using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public DateTime Date { get; set; }
        public Speaker Speaker { get; set; }
        public Bishopric Presiding { get; set; }

        [Display(Name = "Opening Hymn")]
        public Hymn OpeningHymn { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public Hymn SacramentHymn { get; set; }

        [Display(Name = "Intermediate Hymn")]
        public Hymn IntermediateHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        public Hymn ClosingHymn { get; set; }

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }
    }
}
