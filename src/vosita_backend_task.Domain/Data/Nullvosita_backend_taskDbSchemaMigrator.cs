using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace vosita_backend_task.Data;

/* This is used if database provider does't define
 * Ivosita_backend_taskDbSchemaMigrator implementation.
 */
public class Nullvosita_backend_taskDbSchemaMigrator : Ivosita_backend_taskDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
