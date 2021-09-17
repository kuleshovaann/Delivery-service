using DeliverySystem.DAL.Data;
using DeliverySystem.DAL.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Delivery_Service.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dataContext = new DataContext();
            UnitOfWork unitOfWork = new UnitOfWork(dataContext);
            var creator = new DataCreator(unitOfWork);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
