﻿using AgileSlot.SignalR.Core.Client;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SignalR.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
