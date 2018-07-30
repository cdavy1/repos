using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormApplication.Models
{
    public class BCPPlan

    {
        public int Id { get; set; }
        [Required]
        public string PlanName { get; set; }
        public string Company { get; set; }
        public int CustomerId { get; set; }
        [Required]
        [StringLength (50,MinimumLength= 3)]
        public string ThePlan { get; set; }
    }
}
