using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenQuynhAnh056.Models;

    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext (DbContextOptions<AplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenQuynhAnh056.Models.CompanyNQA056> CompanyNQA056 { get; set; } = default!;
    }
