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
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Presiding { get; set; }

        [Display(Name = "Opening Hymn")]
        [Required]
        public string OpeningHymn { get; set; }

        [Display(Name = "Opening Hymn #")]
        [Required]
        public int OpeningHymnNumber { get; set; }

        [Display(Name = "Opening Prayer")]
        [Required]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [Required]
        public string SacramentHymn { get; set; }

        [Display(Name = "Sacrament Hymn #")]
        [Required]
        [Range(1, 341)]
        public int SacramentHymnNumber { get; set; }

        [Display(Name = "Speaker Name")]
        public Speaker Speaker { get; set; }

        //[Display(Name = "Speakers")]
        //public ICollection<Speaker> Speakers { get; set; }

        [Display(Name = "Intermediate Hymn (Optional)")]
        public string? IntermediateHymn { get; set; }

        [Display(Name = "Intermediate Hymn # (Optional)")]
        [Range(0, 341)]
        public int? IntermediateHymnNumber { get; set; }

        [Display(Name = "Closing Hymn")]
        [Required]
        public string ClosingHymn { get; set; }

        [Display(Name = "Closing Hymn #")]
        [Required]
        [Range(1, 341)]
        public int ClosingHymnNumber { get; set; }

        [Display(Name = "Closing Prayer")]
        [Required]
        public string ClosingPrayer { get; set; }
    }
}
