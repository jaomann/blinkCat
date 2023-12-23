using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace blinkRepository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        //nao consigo iniciar o projeto, por conta  da connection string, e nem consigo fazer um commit no banco novo, por erro na construção de um objeto
        // dessa classe.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }
    }
}
