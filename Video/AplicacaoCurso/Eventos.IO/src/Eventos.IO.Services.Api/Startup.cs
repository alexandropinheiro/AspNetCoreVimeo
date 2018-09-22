using AutoMapper;
using Eventos.IO.Infra.CrossCutting.Bus;
using Eventos.IO.Infra.CrossCutting.Identity.Data;
using Eventos.IO.Infra.CrossCutting.Identity.Models;
using Eventos.IO.Infra.CrossCutting.IoC;
using Eventos.IO.Services.Api.Configurations;
using Eventos.IO.Services.Api.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;

namespace Eventos.IO.Services.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddOptions();
            services.AddMvc(options => {
                options.OutputFormatters.Remove(new XmlDataContractSerializerOutputFormatter());
                options.UseCentralRoutePrefix(new RouteAttribute("api/v{version}"));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAutoMapper();
            services.AddSwaggerGen(s => {
                s.SwaggerDoc("v1", new Info {
                    Version = "v1",
                    Title = "Eventos.IO API",
                    Description = "API do site Eventos.IO",
                    TermsOfService = "Nenhum",
                    Contact = new Contact { Name = "Desenvolvedor X", Email="email@eventos.io", Url= "http://eventos.io" },
                    License= new License { Name="MIT", Url= "http://eventos.io/licensa" }
                });
            });

            //REgistrar todos os DI
            RegisterServices(services);
        }

        public void Configure(IApplicationBuilder app, 
                              IHostingEnvironment env,
                              ILoggerFactory loggerFactory,
                              IHttpContextAccessor accessor)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseIdentity();
            app.UseMvc();

            app.UseSwaggerAuthorized();
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Eventos.IO API v1.0");
            });

            InMemoryBus.ContainerAccessor = () => accessor.HttpContext.RequestServices;
        }

        public static void RegisterServices(IServiceCollection services)
        {
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
