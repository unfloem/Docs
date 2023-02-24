using Docs;

await using (DatabaseContext context = new DatabaseContext())
{
    Receipt receipt = new();
    
    Pacient pacient = new("Григорий", "Кузнечиков");
    pacient.Receipts.Add(receipt);
    context.Pacient.Add(pacient);
    
    Doctor doctor = new("Хирург", "Анатолий", "Трамп");
    doctor.Receipts.Add(receipt);
    context.Doctor.Add(doctor);
    
    await context.SaveChangesAsync();
}