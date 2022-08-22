using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestASP.Models
{
    public class Player
    {
        [Range(1, 1000, ErrorMessage ="Must Be 1- 1000")]
        [Required(ErrorMessage = "Must Enter ID")]
        public int? ID { get; set; }
        [StringLength(60, MinimumLength =2,ErrorMessage ="At Least 3 Characters")]
        [Required(ErrorMessage = "Must Enter Name")]
        public string Name { get; set; }

        [RegularExpression(@"[0-9]{10}", ErrorMessage ="Must Enter Valid Phone Number")]
        [Required(ErrorMessage ="Must Enter Phone")]
        public string Phone { get; set; }
    }
}
