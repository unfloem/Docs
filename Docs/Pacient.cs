using System.ComponentModel.DataAnnotations;

namespace Docs;

// Пациент
public class Pacient
{
    [Required]
    public int MedicalBookId { get; init; }
    
    [Required]
    public DateOnly Birthday { get; init; }

    [Required]
    public string FirstName { get; private set; } = null!;
    
    [Required]
    public string LastName { get; private set; } = null!;
    
    public string? Patronymic { get; private set; }
    
    public string? Address { get; private set; }
    
    public string? Phone { get; private set; }

    public List<Receipt> Receipts { get; init; } = new();

    public Pacient(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}


