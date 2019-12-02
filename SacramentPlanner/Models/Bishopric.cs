using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SacramentPlanner.Models
{
    public class Bishopric
    {
        public int BishopricId { get; set; }
        [Display(Name = "Bishopric Position")]

        public String BishopricPosition { get; set; }
        [Display(Name = "Name")]
        public String BishopricName { get; set; }
    }
}
