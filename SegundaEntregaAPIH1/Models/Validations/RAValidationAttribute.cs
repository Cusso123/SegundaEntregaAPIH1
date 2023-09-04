using System.ComponentModel.DataAnnotations;

namespace Aluno.Models.Validations
{
    public class RAValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Console.WriteLine("Validando " + value);
            if (value == null || !value.ToString().StartsWith("RA") || value.ToString().Length != 8)
            {
                Console.WriteLine(" nao é valido " + value);
                return new ValidationResult("RA inválido");
            }

            for (int i = 2; i < 8; i++)
            {
                char digit = value.ToString()[i];
                if (!Char.IsDigit(digit))
                {
                    return new ValidationResult("RA inválido");
                }
            }

            return ValidationResult.Success;
        }
    }
}
