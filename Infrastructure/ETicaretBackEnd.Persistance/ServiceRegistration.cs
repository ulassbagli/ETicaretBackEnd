using ETicaretBackEnd.Application.Abstraction;
using ETicaretBackEnd.Persistence.Concretes;
using ETicaretBackEnd.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBackEnd.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretDbContext>(options => options.UseSqlServer(Configurations.ConnectionStrings));
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
