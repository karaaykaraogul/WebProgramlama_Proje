using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Data
{
    public class MuslukDbContext : IdentityDbContext
    {
        public MuslukDbContext(DbContextOptions<MuslukDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
