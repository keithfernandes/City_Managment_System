
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjCRS.Models
{
    public class Criminal
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Criminal), "BirthDateInThePast")]
        public DateTime BirthDate { get; set; }
        [Required]
        [CustomValidation(typeof(Criminal), "GenderInput")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
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
        public bool Employed { get; set; }
        [Range(0, 999999999)]
        public int? Income { get; set; }
        [Display(Name = "Education Level")]
        public string EducationLevel { get; set; }
        public ICollection<CriminalActivity> CriminalActivities { get; set; }

        public string FullName {
            get { return $"{FirstName} {LastName}"; }
        }


        public static ValidationResult BirthDateInThePast(DateTime BirthDate, ValidationContext context) {        
            if (BirthDate == null) {
                return ValidationResult.Success;
            }
            if (BirthDate < DateTime.Today) {
                return ValidationResult.Success;
            }
            return new ValidationResult("Birth date must be in the past");        
        }
        
        public static ValidationResult GenderInput(string Gender, ValidationContext context) {        
            if (Gender == "Male" || Gender == "Female") {
                return ValidationResult.Success;
            }
            else {
                return new ValidationResult("The value should be 'Male' or 'female'.");  
            }       
        }
    }
}
            