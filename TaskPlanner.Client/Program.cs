using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TaskPlanner.Client;
using TaskPlanner.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7065") });

builder.Services.AddScoped<TaskService>();

builder.Services.AddScoped<TaskPlanner.Client.Services.AppState>();

await builder.Build().RunAsync();
