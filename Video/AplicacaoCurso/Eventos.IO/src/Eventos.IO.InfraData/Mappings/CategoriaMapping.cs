using Eventos.IO.Domain.Eventos;
using Eventos.IO.InfraData.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventos.IO.InfraData.Mappings
{
    public class CategoriaMapping : EntityTypeConfiguration<Categoria>
    {
        public override void Map(EntityTypeBuilder<Categoria> builder)
        {
            builder.Property(o => o.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Ignore(e => e.ValidationResult);

            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Categorias");
        }
    }
}
