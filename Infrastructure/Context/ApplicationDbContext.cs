using Domain.Entities;
//using Infrastructure.Context;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext
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
