
using LojaWeb;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace LojaWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //criamos o m�todo de extens�o CreateAdminRole
            CreateHostBuilder(args)
               .Build()
               
               .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
