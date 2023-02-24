using Microsoft.EntityFrameworkCore;

namespace Docs;

public class DatabaseContext : DbContext
{
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<Doctor> Doctor { get; set; }
    public DbSet<Pacient> Pacient { get; set; }

    public DatabaseContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=main.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Receipt>().HasKey(r => r.Id);
        modelBuilder.Entity<Receipt>().HasOne<Doctor>().WithMany(d => d.Receipts).HasForeignKey(r => r.DoctorId);
        modelBuilder.Entity<Receipt>().HasOne<Pacient>().WithMany(p => p.Receipts).HasForeignKey(r => r.DoctorId);
        
        modelBuilder.Entity<Doctor>().HasKey(d => d.Id);
        modelBuilder.Entity<Pacient>().HasKey(p => p.MedicalBookId);
    }
}