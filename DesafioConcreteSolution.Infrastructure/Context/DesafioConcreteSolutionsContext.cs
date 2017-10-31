using DesafioConcreteSolution.Domain.Model;
using DesafioConcreteSolution.Infrastructure.Mapping;
using System.Data.Entity;

namespace DesafioConcreteSolution.Infrastructure.Context
{
    public class DesafioConcreteSolutionsContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        public DesafioConcreteSolutionsContext() : base("DesafioConcreteSolutionsContext")
        {
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new TelefoneMap());
        }
    }
}