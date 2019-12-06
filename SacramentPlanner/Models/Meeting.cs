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
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Presiding { get; set; }

        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Display(Name = "Hymn #")]
        public int OpeningHymnNumber { get; set; }

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Display(Name = "Hymn #")]
        public int SacramentHymnNumber { get; set; }

        [Display(Name = "Speakers")]
        public ICollection<Speaker> Speakers { get; set; }

        [Display(Name = "Intermediate Hymn (Optional")]
        public string IntermediateHymn { get; set; }

        [Display(Name = "Hymn # (Optional)")]
        public int IntermediateHymnNumber { get; set; }

        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [Display(Name = "Hymn #")]
        public int ClosingHymnNumber { get; set; }

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }
    }
}
