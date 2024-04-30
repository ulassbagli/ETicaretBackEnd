using ETicaretBackEnd.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBackEnd.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public void SomeMethod()
        {
            if (IsDeleted())
            {
                //ürün silinmiş ise şunları yap...
            }
            else 
            {
                //ürün silinmemiş ise şunları yap...
            }
        }
    }
}
