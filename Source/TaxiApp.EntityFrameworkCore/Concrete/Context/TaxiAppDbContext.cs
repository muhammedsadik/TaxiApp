using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Entities.Users;

namespace TaxiApp.EntityFrameworkCore.Concrete.Context
{
  public class TaxiAppDbContext : DbContext
  {


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TaxiApp;Username=postgres;Password=12345;");
      base.OnConfiguring(optionsBuilder);
    }

    public DbSet<User> Users { get; set; }


  }
}
