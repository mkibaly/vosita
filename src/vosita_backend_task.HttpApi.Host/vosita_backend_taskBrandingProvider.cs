using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace vosita_backend_task;

[Dependency(ReplaceServices = true)]
public class vosita_backend_taskBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "vosita_backend_task";
}
