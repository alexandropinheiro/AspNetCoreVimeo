using Eventos.IO.Domain.Core.Models;
using Eventos.IO.Domain.Interfaces;
using Eventos.IO.InfraData.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Eventos.IO.InfraData.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected EventosContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(EventosContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }        

        public virtual TEntity ObterPorId(Guid Id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(t => t.Id == Id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(Guid Id)
        {
            DbSet.Remove(DbSet.Find(Id));
        }

        public int SalvarAlteracoes()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
