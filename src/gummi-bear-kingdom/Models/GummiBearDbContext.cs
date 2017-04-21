using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace gummi_bear_kingdom.Models
{
    public class GummiBearDbContext: DbContext
    {
        public GummiBearDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=gummi_bear_kingdom;integrated security=True");
        }

        public GummiBearDbContext(DbContextOptions<GummiBearDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
