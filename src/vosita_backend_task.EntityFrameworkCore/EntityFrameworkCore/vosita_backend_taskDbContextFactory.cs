using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace vosita_backend_task.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class vosita_backend_taskDbContextFactory : IDesignTimeDbContextFactory<vosita_backend_taskDbContext>
{
    public vosita_backend_taskDbContext CreateDbContext(string[] args)
    {
        vosita_backend_taskEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<vosita_backend_taskDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"), x=> x.UseNetTopologySuite());

        return new vosita_backend_taskDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../vosita_backend_task.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
