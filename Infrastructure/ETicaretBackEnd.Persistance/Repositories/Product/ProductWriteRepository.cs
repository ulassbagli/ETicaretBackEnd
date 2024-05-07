﻿using ETicaretBackEnd.Application.Repositories;
using ETicaretBackEnd.Domain.Entities;
using ETicaretBackEnd.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBackEnd.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}
