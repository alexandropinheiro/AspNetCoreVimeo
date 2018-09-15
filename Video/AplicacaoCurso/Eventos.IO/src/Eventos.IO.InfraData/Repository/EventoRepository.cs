using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
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

        public override IEnumerable<Evento> ObterTodos()
        {
            var sql = "SELECT * FROM EVENTOS E " +
                      " WHERE E.EXCLUIDO = 0 " +
                      " ORDER BY E.DATAFIM DESC";

            return Db.Database.GetDbConnection().Query<Evento>(sql);
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
            var sql = @"SELECT * FROM ENDERECOS E " +
                      " WHERE E.ID = @uid";

            var endereco = Db.Database.GetDbConnection().Query<Endereco>(sql, new { uid = id });
            return endereco.SingleOrDefault();
        }

        public IEnumerable<Evento> ObterEventoPorOrganizador(Guid organizadorId)
        {
            var sql = @"SELECT * FROM EVENTOS E " +                      
                      " WHERE E.EXCLUIDO = 0 " +
                      "   AND E.ORGANIZADORID = @oid " +
                      " ORDER BY E.DATAFIM DESC";

            var eventos = Db.Database.GetDbConnection().Query<Evento>(sql, new { oid = organizadorId });
            return eventos;
        }

        public override Evento ObterPorId(Guid id)
        {
            var sql = "SELECT * FROM EVENTOS E " +
                      "  LEFT JOIN ENDERECOS EN " +
                      "   ON E.ID = EN.EVENTOID " +
                      " WHERE E.ID = @uid";

            var evento = Db.Database.GetDbConnection().Query<Evento, Endereco, Evento>(sql,
                (e, en) =>
                {
                    if (en != null)
                        e.AtribuirEndereco(en);
                    return e;
                }, new { uid = id });

            return evento.FirstOrDefault();

            //Isso é um Inner Join
            //return Db.Eventos.Include(e => e.Endereco).FirstOrDefault(e => e.Id == Id);
        }
    }
}
