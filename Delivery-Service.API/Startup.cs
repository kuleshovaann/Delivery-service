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
            services.AddMvc();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Delivery_Service.API", Version = "v1" });
            });

            services.AddTransient<DataContext>();
            services.AddTransient<UnitOfWork>();

            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<IProviderServices, ProviderServices>();
            services.AddTransient<IOrderServices, OrderServices>();
            services.AddTransient<ICustomerServices, CustomerServices>();

            services.AddSingleton<IRepository<Customer>, Repository<Customer>>();
            services.AddSingleton<IRepository<Delivery>, Repository<Delivery>>();
            services.AddSingleton<IRepository<Order>, Repository<Order>>();
            services.AddSingleton<IRepository<Product>, Repository<Product>>();
            services.AddSingleton<IRepository<Provider>, Repository<Provider>>();
            
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
