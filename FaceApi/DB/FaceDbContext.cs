using FaceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FaceApi.DB;

public class FaceDbContext(DbContextOptions<FaceDbContext> options) : DbContext(options)
{
    
    
    public DbSet<Person> Persons { get; set; }
    
    public DbSet<Camera> Cameras { get; set; }
    
    public DbSet<FaceRecognitionEvent> FaceRecognitionEvents { get; set; }
    
    public DbSet<FaceMetadata> FaceMetadatas { get; set; }
    
    public DbSet<FaceVector> FaceVectors { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FaceMetadata>()
            .Property(f => f.Gender)
            .HasConversion<string>(); // Store enum as string
        

        modelBuilder.Entity<FaceMetadata>()
            .HasOne(f => f.Person)
            .WithMany()
            .HasForeignKey(f => f.Id)
            .OnDelete(DeleteBehavior.Restrict);
        

        modelBuilder.Entity<FaceVector>()
            .HasOne(f => f.Person)
            .WithMany()
            .HasForeignKey(f => f.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}