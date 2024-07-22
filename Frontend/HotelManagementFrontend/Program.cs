// public class Program
// {
//     public static void Main(string[] args)
//     {
//         var builder = WebAssemblyHostBuilder.CreateDefault(args);
//         builder.RootComponents.Add<App>("app");

//         builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//         await builder.Build().RunAsync();
//     }
// }
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using HotelManagementFrontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");

await builder.Build().RunAsync();
