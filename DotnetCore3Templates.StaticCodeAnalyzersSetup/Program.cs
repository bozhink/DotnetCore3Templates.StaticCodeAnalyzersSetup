// <copyright file="Program.cs" company="DotnetCore3Templates">
// Copyright (c) 2020 DotnetCore3Templates. All rights reserved.
// </copyright>

namespace DotnetCore3Templates.StaticCodeAnalyzersSetup
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
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