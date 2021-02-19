using iNile.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iNile.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        }
        public DbSet<Category> Category { set; get; }
        public DbSet<ApplicationType> ApplicationType { set; get; } 
    }
}
