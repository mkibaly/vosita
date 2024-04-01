using vosita_backend_task.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace vosita_backend_task.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(vosita_backend_taskEntityFrameworkCoreModule),
    typeof(vosita_backend_taskApplicationContractsModule)
    )]
public class vosita_backend_taskDbMigratorModule : AbpModule
{
}
