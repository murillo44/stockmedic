using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace DAL
{
    //comandos clave:
    // dotnet tool install --global dotnet-ef
    // dotnet ef migrations add InitialCreate --project DAL --startup-project UI
    // dotnet ef database update --project DAL --startup-project UI

    //dependencias:
    // EntityFrameworkCore
    // EntityFrameworkCore.Design
    // EntityFrameworkCore.Relational
    // EntityFrameworkCore.SqlServer
    // EntityFrameworkCore.Tools

    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        private readonly static string connectionString = ConfigurationManager.ConnectionStrings["DbStockMedic"].ConnectionString;

        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
