using System;
using System.Collections.Generic;
using Dealership.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}
