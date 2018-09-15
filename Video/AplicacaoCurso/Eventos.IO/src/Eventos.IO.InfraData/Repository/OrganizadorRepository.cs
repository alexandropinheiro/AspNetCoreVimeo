using Eventos.IO.Domain.Organizadores;
using Eventos.IO.Domain.Organizadores.Repository;
using Eventos.IO.InfraData.Context;

namespace Eventos.IO.InfraData.Repository
{
    public class OrganizadorRepository : Repository<Organizador>, IOrganizadorRepository
    {
        public OrganizadorRepository(EventosContext context) : base(context)
        {
        }
    }
}
