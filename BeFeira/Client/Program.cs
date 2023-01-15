global using BeFeira.Services.StandServices;
global using BeFeira.Client.Services.FeiraServices;
global using BeFeira.Shared;
using BeFeira.Client;
using BeFeira.Client.Services.ProdutoServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BeFeira.Client.Services.SubcategoriaServices;
using BeFeira.Client.Services.VendedorServices;
using BeFeira.Client.Services.ClienteServices;
using BeFeira.Client.Services.CarrinhoServices;
using BeFeira.Client.Services.NovaPasta;
using BeFeira.Client.Services.CarrinhoProdServices;
using BeFeira.Client.Services.VendaService;
using BeFeira.Client.Services.VendaProdServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IStandService,StandService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IFeiraService, FeiraService>();
builder.Services.AddScoped<ISubcatserv, SubCatService>();
builder.Services.AddScoped<IVendedorService, VendedorService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<ICarrinhoService, CarrinhoService>();
builder.Services.AddScoped<ICarrinhoProdService, CarrinhoProdService>();
builder.Services.AddScoped<IVendaService, VendaService>();
builder.Services.AddScoped<IVendaProdService, VendaProdService>();



await builder.Build().RunAsync();
