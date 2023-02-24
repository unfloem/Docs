using System.ComponentModel.DataAnnotations;

namespace Docs;

// Врач
public class Doctor
{
    [Required]
    public int Id { get; init; }
    
    [Required]
    public string Specialization { get; private set; } = null!;
    
    [Required]
    public string FirstName { get; private set; } = null!;
    
    [Required]
    public string LastName { get; private set; } = null!;
    
    public string? Patronymic { get; private set; }
    
    [Required]
    public decimal AdmissionCost { get; private set; }  // Стоимость приёма
    
    [Required]
    public decimal DeductionPercentage { get; private set; }  // Процент отчисления
    
    [Required]
    public decimal Salary { get; private set; }  // Зарплата

    public List<Receipt> Receipts { get; init; } = new();

    public Doctor(string specialization, string firstName, string lastName)
    {
        Specialization = specialization;
        FirstName = firstName;
        LastName = lastName;
    }
}



