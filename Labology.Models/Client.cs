using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Labology.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Enter Name")]
        public string? CName { get; set; }
        [Required]
        [Display(Name = "Mobile No.")]
        public int? Mobile { get; set; }
        [Required]
        [Display(Name = "District")]
        public string? Dist { get; set; }
        [Required]
        [Display(Name = "Post")]
        public string? Pos { get; set; }
        [Required]
        [Display(Name = "Pin Code")]
        public int? Pin { get; set; }
        [Required]
        [Display(Name = "Land Mark")]
        public string? LandMark { get; set; }
        [Required]
        [Display(Name = "Total Price")]
        public double? Total { get; set; }
        public int? OfficerId { get; set; }
        [ForeignKey("OfficerId")]
        [ValidateNever]
        [Required]
        public Officer? Officer { get; set; }

        public string? ImageUrl { get; set; }

    }
}
