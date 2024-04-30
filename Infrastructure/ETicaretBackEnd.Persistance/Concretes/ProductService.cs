using ETicaretBackEnd.Application.Abstraction;
using ETicaretBackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ETicaretBackEnd.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
             new (){Id = Guid.NewGuid() ,Name = "Product 1", Price= 120, Stock= 450, CreatedDate = DateTime.Now},
         };
    }
}
