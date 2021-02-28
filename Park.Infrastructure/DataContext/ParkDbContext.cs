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
    public ParkDbContext(DbContextOptions<ParkDbContext> options) : base (options)
    {
      
    }

    public DbSet<Park> Type { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Park>().HasData(
        new Park = new Park()
        {
          Created =  ,
          Established = ,
          Id = "86859558-7e97-4e84-9c5d-3065e7d3967e",
          State = "New"
        }


      )
    base.OnModelCreating(modelBuilder);
    }
  }
}
