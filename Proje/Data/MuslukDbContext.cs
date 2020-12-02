using Microsoft.EntityFrameworkCore;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Data
{
    public class MuslukDbContext : DbContext
    {
        public MuslukDbContext(DbContextOptions<MuslukDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
