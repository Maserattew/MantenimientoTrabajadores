using Microsoft.EntityFrameworkCore;
using MantenimientoTrabajadores.Models; // en lugar de .Data

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configurar EF con SQL Server
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();

        // Rutas
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Trabajadores}/{action=Index}/{id?}");

        app.Run();
    }
}