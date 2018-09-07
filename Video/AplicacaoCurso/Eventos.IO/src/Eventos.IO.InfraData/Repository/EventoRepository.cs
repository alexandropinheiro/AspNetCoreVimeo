using System;
using System.Collections.Generic;
using System.Linq;
using Eventos.IO.Domain.Eventos;
using Eventos.IO.Domain.Eventos.Repository;
using Eventos.IO.InfraData.Context;
using Microsoft.EntityFrameworkCore;

namespace Eventos.IO.InfraData.Repository
{
    public class EventoRepository : Repository<Evento>, IEventoRepository
    {
        public EventoRepository(EventosContext context) : base(context)
        {

        }
        public void AdicionarEndereco(Endereco endereco)
        {
            Db.Enderecos.Add(endereco);
        }

        public void AtualizarEndereco(Endereco endereco)
        {
            Db.Enderecos.Update(endereco);
        }

        public Endereco ObterEnderecoPorId(Guid id)
        {
            return Db.Enderecos.Find(id);
        }

        public IEnumerable<Evento> ObterEventoPorOrganizador(Guid organizadorId)
        {
            return Db.Eventos.Where(e => e.OrganizadorId == organizadorId);
        }

        public override Evento ObterPorId(Guid Id)
        {
            //Isso é um Inner Join
            return Db.Eventos.Include(e => e.Endereco).FirstOrDefault(e => e.Id == Id);
        }
    }
}
