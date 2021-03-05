using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parks.Core;

namespace ParkAPI.DataContext
{
  public class ParkDbContext : DbContext
  {
    public ParkDbContext(DbContextOptions<ParkDbContext> options) : base(options)
    {

    }

    public DbSet<Park> Type { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Park>().HasData(
        new Park()
        {
          Created = DateTime.Now,
          Established = DateTime.Today,
          Id = Guid.Parse("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4"),
          State = "New",
          Name = "MyName"
        }
      );
      modelBuilder.Entity<Park>().HasData(
        new Park()
        {
          Created = DateTime.Parse("1990-10-12"),
          Established = DateTime.FromBinary(101000010101111),
          Id = Guid.NewGuid(),
          Name = "Alabama",
          State = String.Concat("my Dear Frodo" + "Back and Again")
        });
      base.OnModelCreating(modelBuilder);
    }
  }
}
