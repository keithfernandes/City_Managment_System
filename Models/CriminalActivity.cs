
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjCRS.Models
{
    public class CriminalActivity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Time of Occurance")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(CriminalActivity), "TimeOfOccuranceInThePast")]
        public DateTime TimeOfOccurance { get; set; }

       
        
        public Criminal Criminal { get; set; }
        [Display(Name = "Name of Criminal")]
        public int CriminalId { get; set; }
      
        public CrimeLocation Location { get; set; }
        [Display(Name = "Location of Crime")]
        public int LocationId { get; set; }
       

        
       
        
     
        

        
        public CriminalCode CriminalCode { get; set; }
        [Display(Name = "Criminal Code")]
        public int CriminalCodeId { get; set; }
        [Required]
        [Display(Name = "Case Status")]
        public string CaseStatus { get; set; }

        public static ValidationResult TimeOfOccuranceInThePast(DateTime TimeOfOccurance, ValidationContext context) {        
            if (TimeOfOccurance == null) {
                return ValidationResult.Success;
            }
            if (TimeOfOccurance < DateTime.Today) {
                return ValidationResult.Success;
            }
            return new ValidationResult("Time of Occurance must be in the past");
        }
    }
}
            