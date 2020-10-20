using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CMS.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CMS
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // this section sets up and seeds the database. It would NOT normally
            // be done this way in production. It is here to make the sample easier,
            // i.e. clone, set connection string and run.
            var options = host.Services.GetService<IServiceScopeFactory>()
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<DbContextOptions<ContactContext>>();
            await options.EnsureDbCreatedAndSeedWithCountOfAsync(10);
            // back to your regularly scheduled program

            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
