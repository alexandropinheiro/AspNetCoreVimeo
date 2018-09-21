using System;
using System.Linq;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.IO.Services.Api.Controllers
{
    [Produces("application/json")]
    public abstract class BaseController : Controller
    {
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;

        protected Guid OrganizadorId { get; set; }
        protected BaseController(IDomainNotificationHandler<DomainNotification> notifications, 
                              IUser user)
        {
            _notifications = notifications;

            if (user.IsAuthenticated())
            {
                OrganizadorId = user.GetUserId();
            }
        }

        protected bool OperacaoValida()
        {
            return _notifications.HasNotifications();
        }

        protected new IActionResult Response(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(new {
                    success = true,
                    data = result
                });
            }
            return BadRequest(new
            {
                success = false,
                errors = _notifications.GetNotifications().Select(n => n.Value)
            });
        }


    }
}
