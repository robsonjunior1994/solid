using System;
using Microsoft.EntityFrameworkCore;
using Sem_SRP.Models;

namespace Sem_SRP
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AppDB;Trusted_Connection=true");
        }
    }
}