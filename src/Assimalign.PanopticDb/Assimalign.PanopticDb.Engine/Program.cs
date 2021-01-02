using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Assimalign.PanopticDb.Engine
{
    using Configurations;
    using Assimalign.PanopticDb.Execution;
    

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddOptions<ServerConfigurations>()
                        .Configure<IConfiguration>((settings, configure) =>
                        {
                            configure.GetSection("").Bind(settings);
                        });

                    services.AddSingleton<IDatParser, DatParser>(serviceProvider =>
                        new DatParser(serviceProvider.GetRequiredService<IOptions<ServerConfigurations>>().Value.DatFilePath, FileMode.OpenOrCreate));
                   

                    
                });
    }
}
