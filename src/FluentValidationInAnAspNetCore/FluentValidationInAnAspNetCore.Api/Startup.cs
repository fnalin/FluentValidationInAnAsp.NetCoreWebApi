using FluentValidationInAnAspNetCore.Data.EF;
using FluentValidationInAnAspNetCore.Data.EF.Repositories;
using FluentValidationInAnAspNetCore.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FluentValidationInAnAspNetCore.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<StoreDataContext>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, StoreDataContext ctx)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                ctx.Database.EnsureCreated();
            }

            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
