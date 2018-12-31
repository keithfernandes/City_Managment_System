
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjCRS.Models
{
    public class CrimeLocation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "2 - 30 characters only")]
        public string City { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "2 - 20 characters only")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        [RegularExpression(@"\d{5}$", ErrorMessage = "Invalid Zip Code")]
        public string ZipCode { get; set; }

        public ICollection<CriminalActivity> CriminalActivities { get; set; }

        public string FullAddress {
        get { return $"{StreetAddress}, {City}, {State}, {ZipCode}"; }
        }
    }
}
            