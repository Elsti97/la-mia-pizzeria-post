using System.ComponentModel.DataAnnotations;
namespace la_mia_pizzeria_static.Attributes;

public class NWord : ValidationAttribute
{
    int wordCount;

    public NWord(int wordCount)
    {
        this.wordCount = wordCount;
    }

    protected override ValidationResult IsValid(object? value, ValidationContext _)
    {
        var input = value as string;

        if (input is null || input.Trim().Split(' ').Length < wordCount)
        {
            return new ValidationResult(ErrorMessage ?? $"Perfavore, inserisci almeno {wordCount} parole");
        }

        return ValidationResult.Success!;
    }
}
