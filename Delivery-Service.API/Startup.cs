using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;
using DeliverySystem.DAL.Data;
using Microsoft.EntityFrameworkCore;

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
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddMvc();
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connection));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Delivery_Service.API", Version = "v1" });
            });

            //services.AddTransient<IRepository<Customer>, Repository<Customer>>();
            //services.AddTransient<IRepository<Delivery>, Repository<Delivery>>();
            //services.AddTransient<IRepository<Order>, Repository<Order>>();
            //services.AddTransient<IRepository<Product>, Repository<Product>>();
            //services.AddTransient<IRepository<Provider>, Repository<Provider>>();
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
                endpoints.MapControllers();
            });
        }
    }
}
