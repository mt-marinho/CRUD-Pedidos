using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud1.Models;

namespace Crud1.Data
{
    public class Crud1Context : DbContext
    {
        public Crud1Context (DbContextOptions<Crud1Context> options)
            : base(options)
        {
        }

        public DbSet<Crud1.Models.Pedido> Pedido { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .Property(p => p.Valor)
                .HasColumnType("decimal(18,2)");
        }
    }
}
