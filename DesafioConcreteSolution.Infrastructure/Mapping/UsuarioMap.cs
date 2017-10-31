using DesafioConcreteSolution.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace DesafioConcreteSolution.Infrastructure.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
            Property(x => x.Senha).HasColumnName("SENHA").HasMaxLength(100).IsRequired();
            Property(x => x.Email).HasColumnName("EMAIL").HasMaxLength(100).IsRequired();
            Property(x => x.Token).HasColumnName("TOKEN");
            Property(x => x.DataUltimoLogin).HasColumnName("DATA_ULTIMO_LOGIN");

            Ignore(x => x.Telefones);

            ToTable("USUARIO");
        }
    }
}