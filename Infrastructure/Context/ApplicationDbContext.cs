using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Top> Tops { get; set; }
        public DbSet<Shoe> Shoes { get; set; }

        public DbSet<Lining> Linings { get; set; }
        public DbSet<ColorType> ColorTypes { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<Sole> Soles { get; set; }
    }
}
