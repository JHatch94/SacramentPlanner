using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Topics
    {
        public int TopicsId { get; set; }
        [Display(Name = "Topic")]

        public int TopicName { get; set; }
    }
}
