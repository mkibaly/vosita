using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using vosita_backend_task.Data;
using Volo.Abp.DependencyInjection;

namespace vosita_backend_task.EntityFrameworkCore;

public class EntityFrameworkCorevosita_backend_taskDbSchemaMigrator
    : Ivosita_backend_taskDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorevosita_backend_taskDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the vosita_backend_taskDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<vosita_backend_taskDbContext>()
            .Database
            .MigrateAsync();
    }
}
