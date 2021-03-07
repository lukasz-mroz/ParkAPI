using System;
using Microsoft.EntityFrameworkCore;
using Parks.Cores;

namespace ParkAPI.DataContext
{
  public class ParkDbContext : DbContext
  {

    public ParkDbContext(DbContextOptions<ParkDbContext> options) : base(options)
    {

    }

    public DbSet<Parky> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Parky>().HasData(
        new Parky()
        {
          Created = DateTime.Now,
          Established = DateTime.Today,
          Id = Guid.Parse("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4"),
          State = "New",
          Name = "MyName"
        }
      );
      modelBuilder.Entity<Parky>().HasData(
        new Parky()
        {
          Created = DateTime.Parse("1990-10-12"),
          Established = DateTime.FromBinary(101000010101111),
          Id = Guid.NewGuid(),
          Name = "Alabama",
          State = String.Concat("my Dear Frodo" + " Back and Again")
        });
      base.OnModelCreating(modelBuilder);
    }
  }
}
