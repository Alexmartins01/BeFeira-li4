global using BeFeira.Services.StandServices;
global using BeFeira.Client.Services.FeiraServices;
global using BeFeira.Shared;
using BeFeira.Client;
using BeFeira.Client.Services.ProdutoServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BeFeira.Client.Services.SubcategoriaServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IStandService,StandService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IFeiraService, FeiraService>();
builder.Services.AddScoped<ISubcatserv, SubCatService>();


await builder.Build().RunAsync();
