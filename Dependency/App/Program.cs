using System;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var container = RegisterServices())
      {
        var controller = container.GetRequiredService<HelloController>();
        var helloText = controller.GetHelloText("Oleg");
        Console.WriteLine(helloText);
      }
    }

    static ServiceProvider RegisterServices()
    {
      var service = new ServiceCollection();
      service.AddSingleton<IGreating, Greating>();
      service.AddTransient<HelloController>();
      return service.BuildServiceProvider();
    }
  }
}
