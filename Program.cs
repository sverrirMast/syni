using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace webapi
{
    public class Program
    {
        



        public static void Main(string[] args)
        {
            var connString = "Host=localhost;Username=postgres;Password=stitch188;Database=svin";
            using var conn = new NpgsqlConnection(connString);
            if (conn.OpenAsync() == null) {
                Console.WriteLine("bla");

            }

            Svin svin = new Svin();
            var file = @"kjotsafi.xlsx";
            


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
