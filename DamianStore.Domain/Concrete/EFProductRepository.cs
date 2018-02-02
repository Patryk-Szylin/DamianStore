using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DamianStore.Domain.Abstract;
using DamianStore.Domain.Entities;

namespace DamianStore.Domain.Concrete
{
    class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
