using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Santtoary_.WEB;
using Santtoary_.WEB.Repositories;
using Santtoary_.WEB.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5057/")
});

builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddScoped<SessionService>(); // 👈 aquí ya corregido

// 👇 ESTE ES EL QUE PREGUNTAS (va aquí mismo abajo)
builder.Services.AddScoped(sp =>
{
    var client = new HttpClient
    {
        BaseAddress = new Uri("http://localhost:5057/")
    };

    return client;
});

await builder.Build().RunAsync();