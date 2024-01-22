using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Store.DAL;
using Microsoft.EntityFrameworkCore;
using Store.Business.Store;
using Store.DAL.Repository;
using Store.API.Controllers;
using System;
using Store.Business.Store.Contracts;
using Store.DAL.Repository.Contracts;

namespace Store.API
{
    public class Startup
    {
        IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            services.AddDbContext<StoreDbContext>(option =>
                { 
                    option.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
                }
            );

            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<IProductsService, ProductService>();

            services.AddScoped<IServicesRepository, ServicesRepository>();
            services.AddScoped<IServicesService, ServicesService>();

            services.AddScoped<ISuppliersRepository, SuppliersRepository>();
            services.AddScoped<ISuppliersService, SuppliersService>();

            services.AddScoped<IProductsToSuppliersRepository, ProductsToSuppliersRepository>();
            services.AddScoped<IProductsToSuppliersService, ProductsToSuppliersService>();

            services.AddScoped<IServicesToSuppliersRepository, ServicesToSuppliersRepository>();
            services.AddScoped<IServicesToSuppliersService, ServicesToSuppliersService>();

            services.AddScoped<IProductTypesRepository, ProductTypesRepository>();
            services.AddScoped<IProductTypesService, ProductTypesService>();

            services.AddScoped<IServiceTypesRepository, ServiceTypesRepository>();
            services.AddScoped<IServiceTypesService, ServiceTypesService>();

            services.AddSwaggerGen();
            services.AddEndpointsApiExplorer();
            services.AddControllers();
           
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web Api");
            });

            if (env.IsDevelopment())
            { 
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                endpoints.MapControllers();
            });
        }
    }
}
