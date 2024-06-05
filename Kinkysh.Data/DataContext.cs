using Kinkysh.Data.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Kinkysh.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<UserDao> Users { get; set; } = null!;
    
    public DbSet<UserPicturesDao> UserPictures { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserDao>(entity =>
        {
            entity.ToTable("Users");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Username).IsRequired();
            entity.Property(e => e.Age).IsRequired();
        });
        
        modelBuilder.Entity<UserPicturesDao>(entity =>
        {
            entity.ToTable("UserPictures");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.PictureUrl).IsRequired();
            entity.Property(e => e.UserId).IsRequired();
        });
    }
}