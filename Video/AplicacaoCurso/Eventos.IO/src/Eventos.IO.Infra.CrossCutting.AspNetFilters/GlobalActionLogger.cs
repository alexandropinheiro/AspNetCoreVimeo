using Elmah.Io.Client;
using Elmah.Io.Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eventos.IO.Infra.CrossCutting.AspNetFilters
{
    public class GlobalActionLogger : IActionFilter
    {
        private readonly ILogger<GlobalActionLogger> _logger;
        private readonly IHostingEnvironment _hostingEnviroment;

        public GlobalActionLogger(ILogger<GlobalActionLogger> logger,
                                  IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnviroment = hostingEnvironment;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (_hostingEnviroment.IsDevelopment())
            {
                var data = new
                {
                    version = "v1.0",
                    User = context.HttpContext.User.Identity.Name,
                    IP = context.HttpContext.Connection.RemoteIpAddress.ToString(),
                    HostName = context.HttpContext.Request.Host.ToString(),
                    AreaAccessed = context.HttpContext.Request.GetDisplayUrl(),
                    Action = context.ActionDescriptor.DisplayName,
                    TimeStamp = DateTime.Now
                };

                _logger.LogInformation(1, data.ToString(), "Log de Auditoria");
            }

            if (_hostingEnviroment.IsProduction())
            {
                var message = new CreateMessage
                {
                    Version = "v1.0",
                    Application = "Eventos.IO",
                    Source = "GlobalActionLoggerFilter",
                    User = context.HttpContext.User.Identity.Name,
                    Hostname = context.HttpContext.Request.Host.ToString(),
                    Url = context.HttpContext.Request.GetDisplayUrl(),
                    DateTime = DateTime.Now,
                    Method = context.HttpContext.Request.Method,
                    StatusCode = context.HttpContext.Response.StatusCode,
                    Cookies = context.HttpContext.Request?.Cookies?.Keys.Select(k => new Item(k, context.HttpContext.Request.Cookies[k])).ToList(),
                    Form = Form(context.HttpContext),
                    ServerVariables = context.HttpContext.Request?.Headers?.Keys.Select(k => new Item(k, context.HttpContext.Request.Headers[k])).ToList(),
                    QueryString = context.HttpContext.Request?.Query?.Keys.Select(k => new Item(k, context.HttpContext.Request.Query[k])).ToList(),
                    Data = context.Exception?.ToDataList(),
                    Detail = JsonConvert.SerializeObject(new { DadoExtra = "Dados a mais", DadoInfo = "Pode ser um Json"})
                };

                //Chave da subscription
                var client = ElmahioAPI.Create("");
                client.Messages.Create(new Guid("").ToString(), message);
            }
        }

        private static List<Item> Form(HttpContext httpContext)
        {
            try
            {
                return httpContext.Request?.Form?.Keys.Select(k => new Item(k, httpContext.Request.Form[k])).ToList();
            }
            catch (InvalidOperationException)
            {

            }
            return null;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
