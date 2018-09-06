using Eventos.IO.Domain.Eventos;
using Eventos.IO.Domain.Eventos.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ConsoleTeste
{
    public class FakeEventoRepository : IEventoRepository
    {        
        public void Adicionar(Evento obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> Buscar(Expression<Func<Evento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Evento ObterPorId(Guid Id)
        {
            return null;
            //return new Evento("Fake", DateTime.Now, DateTime.Now, true, 0, true, "Empresa");
        }

        public void Remover(Guid Id)
        {
            //throw new NotImplementedException();
        }

        public int SalvarAlteracoes()
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Evento obj)
        {
            //return new Evento("Fake", DateTime.Now, DateTime.Now, true, 0, true, "Empresa");
        }

        public IEnumerable<Evento> ObterEventoPorOrganizador(Guid organizadorId)
        {
            throw new NotImplementedException();
        }

        public Endereco ObterEnderecoPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public void AtualizarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }
    }
}
