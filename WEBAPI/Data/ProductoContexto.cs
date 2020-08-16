using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI.Models;

namespace WEBAPI.Data
{
    public class ProductoContexto : DbContext
    {
        public ProductoContexto(DbContextOptions<ProductoContexto>options):base(options)
        {

        }

        public DbSet<Productos> ProductosItems { get; set; }
    }

    
}
