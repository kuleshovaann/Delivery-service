using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;
using DeliverySystem.DAL.Data;
using DeliverySystem.DAL.Services;
using Delivery_Service.API.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System;

namespace Delivery_Service.API
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
            services.AddDbContext<DataContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc();
            services.AddControllers(options =>
            {
                options.Filters.Add(typeof(NewExceptionFilter));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Delivery_Service.API", Version = "v1" });
            });

            services.AddScoped<DataContext>();
            services.AddTransient<UnitOfWork>();

            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<IProviderServices, ProviderServices>();
            services.AddTransient<IOrderServices, OrderServices>();
            services.AddTransient<ICustomerServices, CustomerServices>();

            services.AddTransient<IRepository<Customer>, Repository<Customer>>();
            services.AddTransient<IRepository<Delivery>, Repository<Delivery>>();
            services.AddTransient<IRepository<Order>, Repository<Order>>();
            services.AddTransient<IRepository<Product>, Repository<Product>>();
            services.AddTransient<IRepository<Provider>, Repository<Provider>>();

            services.AddScoped<RequestBodyActionFilter>();
            services.AddScoped<NewExceptionFilter>();
            services.AddScoped<ILogger, Logger<NewExceptionFilter>>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Delivery_Service.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "mvcProductGet",
                    pattern: "mvc/product",
                    defaults: new { controller = "ProductMVC", action = "GetProducts" }
                );
                endpoints.MapControllerRoute(
                    name: "mvcProduct",
                    pattern: "mvc/product/{action}/{id?}",
                    defaults: new { controller = "ProductMVC" }
                );
            });
        }
    }
}
