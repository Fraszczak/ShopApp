using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ShopApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Run();
        } 


        //// EF Core uses this method at design time to access the DbContext
        //public static IHostBuilder CreateHostBuilder(string[] args)
        //    => Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(
        //            webBuilder => webBuilder.UseStartup<Startup>());

        
        public static IWebHost CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseDefaultServiceProvider(
                    options => options.ValidateScopes = false)
                .Build();
    }
}

