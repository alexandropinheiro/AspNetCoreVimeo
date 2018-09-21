using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Interfaces;
using Eventos.IO.Domain.Organizadores.Commands;
using Eventos.IO.Infra.CrossCutting.Identity.Models;
using Eventos.IO.Infra.CrossCutting.Identity.Models.AccountViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.IO.Services.Api.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;
        private readonly IBus _bus;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 ILoggerFactory loggerFactory,
                                 IBus bus,
                                 IDomainNotificationHandler<DomainNotification> notifications, 
                                 IUser user) : base(notifications, user)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = loggerFactory.CreateLogger<AccountController>();
            _bus = bus;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("nova-conta")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            if (!ModelState.IsValid) return Response(model);

            var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var registroCommand = new RegistrarOrganizadorCommand(Guid.Parse(user.Id), model.Nome, model.CPF, user.Email);
                _bus.SendCommand(registroCommand);

                if (OperacaoValida())
                {
                    await _userManager.DeleteAsync(user);
                    return Response(model);
                }

                _logger.LogInformation(1, "Usuário criado com sucesso!");
                return Response(model);
            }
            AdicionarErrosIdentity(result);
            return Response(model);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("conta")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            if (!ModelState.IsValid) return Response(model);

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: true);

            if (result.Succeeded)
            {
                _logger.LogInformation(1, "Usuário logado com sucesso!");
                return Response(model);
            }

            NotificarErro(result.ToString(), "Falha ao realizar o Login");
            return Response(model);
        }

        private void NotificarErroModelInvalida()
        {
            var erros = ModelState.Values.SelectMany(v => v.Errors);
            foreach(var erro in erros)
            {
                NotificarErro(string.Empty, erro.ErrorMessage);
            }
        }

        private void NotificarErro(string codigo, string mensagem)
        {
            _bus.RaiseEvent(new DomainNotification(codigo, mensagem));
        }

        private void AdicionarErrosIdentity(IdentityResult result)
        {
            foreach(var error in result.Errors)
            {
                NotificarErro(result.ToString(), error.Description);
            }
        }
    }
}
