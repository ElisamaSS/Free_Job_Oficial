using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Pilot_FreeJob.Models
{
    public class FreeJobDbContext: DbContext
    {
        public FreeJobDbContext(DbContextOptions<FreeJobDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Servico> Servico { get; set; }
        public DbSet<Cadastro> Cadastro { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Cadastro>().HasKey(al => new { al.CategoriaId, al.ServicoId, al.UsuarioId });
        }

    }

}
