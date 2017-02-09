using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace AspnetLab4HtmlHelper.Models.CustomValidation
{
    //must inherit ValidationAttribute
    public class WordCount : ValidationAttribute
    {
        private readonly int _num;
        // [Exclude ("^%$#@!")]
        //inherit base                 //default error mssage
        public WordCount(int num) : base("{0} contains invalid character.")
        {
            _num = num;
        }

        //must override
        //validate the value parameter
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int num = value.ToString().Split(' ').Count();
                if( num > _num )
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success; //note
        }
    }
}