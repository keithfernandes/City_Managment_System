
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjCRS.Models
{
    public class CriminalCode
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"\d{3}$", ErrorMessage = "Invalid Criminal Code")]
        [CustomValidation(typeof(CriminalCode), "CodeValidation")]
        public string Code { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
        public string Description { get; set; }
        public ICollection<CriminalActivity> CriminalActivities { get; set; }

        public string CodeWDescription {
        get { return $"§ {Code}- {Description}"; }
        }

        public static ValidationResult CodeValidation(string Code, ValidationContext context) {
            if (string.IsNullOrWhiteSpace(Code)) {
                return ValidationResult.Success;
            }
            var instance = context.ObjectInstance as CriminalCode;
            if (instance == null) {
                return ValidationResult.Success;
            }

            var dbContext = context.GetService(typeof(AppDbContext)) as AppDbContext;

            int duplicateCount = dbContext.CriminalCode.Count(x => x.Id != instance.Id && x.Code == Code);
            if (duplicateCount > 0) {
                return new ValidationResult($"Code {Code} already exists");
            }
            return ValidationResult.Success;
        }        
    }
}
            