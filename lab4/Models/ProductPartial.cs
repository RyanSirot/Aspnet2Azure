using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab4.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {    }

    public class ProductMetaData
    {
        const int n = 3;

        [Required]
        [Display(Name = "Product Name")]
        [MaxWords(n, ErrorMessage = " {0} Cannot contain more than 3 words")]
        public Object ProductName { get; set; }

        [Display(Name = "Unit Price")]
        public Object UnitPrice { get; set; }


    }


    public class MaxWords : ValidationAttribute
    {
        private readonly int _maxWords;

        public MaxWords(int maxWords)
            : base("{0} has too many words !!")
        {
            _maxWords = maxWords;
        }

        protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > _maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("No Value supplied !!");
            }
        }
    }
    
}