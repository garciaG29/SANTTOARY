using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Santtoary_.WEB;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Cambiamos el BaseAddress para que apunte al puerto donde corre tu API (Swagger)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:8000/") });

await builder.Build().RunAsync();
