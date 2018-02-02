using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DamianStore.Domain.Entities;

namespace DamianStore.Domain.Concrete
{
    class EFDbContext : DbContext
    {
        //public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
