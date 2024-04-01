using Volo.Abp.Modularity;

namespace vosita_backend_task;

/* Inherit from this class for your domain layer tests. */
public abstract class vosita_backend_taskDomainTestBase<TStartupModule> : vosita_backend_taskTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
