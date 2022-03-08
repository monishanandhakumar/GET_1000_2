using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEg.Models
{
    //database
    public class ShoppingContext :DbContext
    {
        public ShoppingContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    }
}
