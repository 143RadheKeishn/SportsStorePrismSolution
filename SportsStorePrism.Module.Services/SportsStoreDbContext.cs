using SportsStorePrism.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStorePrism.Module.Services
{
  public class SportsStoreDbContext : DbContext
   {
      public SportsStoreDbContext() : base("SportStoreConnection") { }

      public DbSet<Product> Products { get; set; }
   }
}
