using Adding_Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adding_Services.Data
{
    public class ProductContex : DbContext
    {
        public ProductContex(DbContextOptions options) : base(options) { }
        public DbSet<Product_DB> Product_DB { get; set; }
    }
}
