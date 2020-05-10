using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DinerBlazorClientApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient
            {
                // TODO: Change this to correct address!
                //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
                //BaseAddress = new Uri("https://localhost:44379")
                BaseAddress = new Uri("https://dinerapi.softwort-developement.com/")

            });

            await builder.Build().RunAsync();
        }
    }
}
