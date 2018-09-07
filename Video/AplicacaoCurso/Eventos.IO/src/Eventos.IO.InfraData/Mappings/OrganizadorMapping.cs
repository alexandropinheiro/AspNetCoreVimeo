using Eventos.IO.Domain.Organizadores;
using Eventos.IO.InfraData.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventos.IO.InfraData.Mappings
{
    public class OrganizadorMapping : EntityTypeConfiguration<Organizador>
    {
        public override void Map(EntityTypeBuilder<Organizador> builder)
        {
            builder.Property(o => o.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(o => o.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(o => o.Cpf)
                .HasColumnType("varchar(11)")
                .HasMaxLength(11)
                .IsRequired();

            builder.Ignore(e => e.ValidationResult);

            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Organizadores");
        }
    }
}
