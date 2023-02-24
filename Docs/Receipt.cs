using System.ComponentModel.DataAnnotations;

namespace Docs;

// Квитанция
public class Receipt {
    [Required]
    public int Id { get; init; }
    
    [Required]
    public DateOnly Date { get; init; }
    
    [Required]
    public int DoctorId { get; init; }
    
    [Required]
    public int PatientId { get; init; }

    public Receipt() => Date = DateOnly.FromDateTime(DateTime.Now);
}



