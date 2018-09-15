using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Eventos.IO.Domain.Interfaces
{
    public interface IUser
    {
        string Name { get; set; }
        Guid GetUserId();
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
