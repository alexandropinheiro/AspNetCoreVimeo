using Eventos.IO.Domain.Eventos;
using Eventos.IO.InfraData.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventos.IO.InfraData.Mappings
{
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public override void Map(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(e => e.Numero)
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(e => e.Bairro)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Cep)
                .HasColumnType("varchar(8)")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(e => e.Complemento)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(e => e.Cidade)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Estado)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne(c => c.Evento)
                .WithOne(c => c.Endereco)
                .HasForeignKey<Endereco>(c => c.EventoId)
                .IsRequired(false);

            builder.Ignore(e => e.ValidationResult);
            
            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Enderecos");
        }
    }
}
