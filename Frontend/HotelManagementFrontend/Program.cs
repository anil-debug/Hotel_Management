// using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
// using Microsoft.AspNetCore.Components.Web;
// using HotelManagementFrontend;

// namespace HotelManagementFrontend
// {
//     public class Program
//     {
//         public static async Task Main(string[] args)
//         {
//             var builder = WebAssemblyHostBuilder.CreateDefault(args);
//             builder.RootComponents.Add<App>("app");

//             builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//             await builder.Build().RunAsync();
//         }
//     }
// }
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.Web;
using HotelManagementFrontend; // Ensure this namespace matches your project's root namespace

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app"); // Ensure the `App` component is available in your project

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
