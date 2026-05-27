using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApp.Data;
using WebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Agregar contexto de la BD como un servicio
builder.Services.AddDbContext<AppDbContext>(
    options => 
    //options.usesqlserver(builder.configuration.getconnectionstring("conexion"))
    options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Proyectores;Integrated Security=True;" +
                         "Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;" +
                         "Multi Subnet Failover=False;Command Timeout=30")

    );

builder.Services.AddTransient<IProyectoresService, ProyectoresService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
