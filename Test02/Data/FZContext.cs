using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test02.Models;

    public class FZContext : DbContext
    {
        public FZContext (DbContextOptions<FZContext> options)
            : base(options)
        {
        }

        public DbSet<Test02.Models.Auto> Auto { get; set; } = default!;
        public DbSet<Test02.Models.Besitzer> Besitzer { get; set; } = default!;

    }
