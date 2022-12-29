using BeFeira.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BeFeiraVendaProdutoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraVendaProdutoContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraVendaProdutoContext' not found.")));
builder.Services.AddDbContext<BeFeiraVendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraVendaContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraVendaContext' not found.")));
builder.Services.AddDbContext<BeFeiraSubcategoriaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraSubcategoriaContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraSubcategoriaContext' not found.")));
builder.Services.AddDbContext<BeFeiraPromocaoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraPromocaoContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraPromocaoContext' not found.")));
builder.Services.AddDbContext<BeFeiraProdutoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraProdutoContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraProdutoContext' not found.")));
builder.Services.AddDbContext<BeFeiraCarrinhoProdutoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraCarrinhoProdutoContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraCarrinhoProdutoContext' not found.")));
builder.Services.AddDbContext<BeFeiraCarrinhoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraCarrinhoContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraCarrinhoContext' not found.")));
builder.Services.AddDbContext<BeFeiraFeiraContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraFeiraContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraFeiraContext' not found.")));
builder.Services.AddDbContext<BeFeiraStandContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraStandContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraStandContext' not found.")));
builder.Services.AddDbContext<BeFeiraVendedorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraVendedorContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraVendedorContext' not found.")));
builder.Services.AddDbContext<BeFeiraClienteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraClienteContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraClienteContext' not found.")));
builder.Services.AddDbContext<BeFeiraContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeFeiraContext") ?? throw new InvalidOperationException("Connection string 'BeFeiraContext' not found.")));
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();