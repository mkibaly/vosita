using Volo.Abp.Modularity;

namespace vosita_backend_task;

[DependsOn(
    typeof(vosita_backend_taskDomainModule),
    typeof(vosita_backend_taskTestBaseModule)
)]
public class vosita_backend_taskDomainTestModule : AbpModule
{

}
