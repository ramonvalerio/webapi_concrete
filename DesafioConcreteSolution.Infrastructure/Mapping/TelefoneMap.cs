using DesafioConcreteSolution.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace DesafioConcreteSolution.Infrastructure.Mapping
{
    public class TelefoneMap : EntityTypeConfiguration<Telefone>
    {
        public TelefoneMap()
        {
            HasKey(x => x.Id);

            Property(x => x.DDD).HasColumnName("DDD").HasMaxLength(100).IsRequired();
            Property(x => x.Numero).HasColumnName("NUMERO").HasMaxLength(100).IsRequired();
            Property(x => x.UsuarioId).HasColumnName("USUARIO_ID").IsRequired();

            ToTable("TELEFONE");
        }
    }
}