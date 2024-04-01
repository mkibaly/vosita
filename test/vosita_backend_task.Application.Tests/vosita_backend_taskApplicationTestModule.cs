using Volo.Abp.Modularity;

namespace vosita_backend_task;

[DependsOn(
    typeof(vosita_backend_taskApplicationModule),
    typeof(vosita_backend_taskDomainTestModule)
)]
public class vosita_backend_taskApplicationTestModule : AbpModule
{

}
