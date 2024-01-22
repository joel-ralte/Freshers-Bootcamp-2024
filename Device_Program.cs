using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_1
{
    public class ObjectValidator
    {
        public static bool Validate(object obj, out List<string> errors)
        {
            errors = new List<string>();

            var context = new ValidationContext(obj, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(obj, context, validationResults, validateAllProperties: true);

            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    errors.Add(validationResult.ErrorMessage);
                }
            }

            return isValid;
        }
    }

    class Device
    {

        [Required(ErrorMessage = "ID Property Requires Value")]
        public string Id { get; set; }
        [Range(10, 100, ErrorMessage ="Code Value Must Be Within 10-100")]
        public int Code { get; set; }

        [MaxLength(100, ErrorMessage = "Max of 100 Charcters are allowed")]
        public string Description { get; set; }

    }

    internal class Program_1
    {
        static void Main()
        {
            Device deviceObj = new Device();
            List<string> errors;
            bool isValid = ObjectValidator.Validate(deviceObj, out errors);
            if (!isValid)
            {
                foreach (string item in errors)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}
