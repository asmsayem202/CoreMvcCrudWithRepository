using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMvcCrudWithRepository.Core
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
