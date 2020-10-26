using Microsoft.EntityFrameworkCore;
using MvcEntrainement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntrainement.Data
{
    public class MvcSoprofenContext : DbContext
    {
        public MvcSoprofenContext(DbContextOptions<MvcSoprofenContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<AppUser> Users { get; set; }
    }
}
