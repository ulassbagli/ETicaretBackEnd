using ETicaretBackEnd.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBackEnd.Persistence.Contexts
{
    public class ETicaretDbContext : DbContext
    {
        public ETicaretDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
