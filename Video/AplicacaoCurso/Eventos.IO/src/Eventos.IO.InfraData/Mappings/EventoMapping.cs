using Eventos.IO.Domain.Eventos;
using Eventos.IO.InfraData.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.InfraData.Mappings
{
    public class EventoMapping : EntityTypeConfiguration<Evento>
    {
        public override void Map(EntityTypeBuilder<Evento> builder)
        {
            builder.Property
        }
    }
}
