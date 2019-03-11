using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.UseCases.Shared;
using Domain.UseCases.Users.Read;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReadUserRequest = Domain.UseCases.Users.Read.Request;
using ReadUserResponse = Domain.UseCases.Users.Read.Response;

namespace MockServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUseCase<ReadUserRequest, ReadUserResponse>, ReadUserUseCase>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "Admin", template: "{controller=Main}/{action=Index}/{id?}");
                routes.MapRoute(name: "Default", template: "api/{*url}", defaults: new { controller = "Router", action = "Index" });
            });
        }
    }
}
