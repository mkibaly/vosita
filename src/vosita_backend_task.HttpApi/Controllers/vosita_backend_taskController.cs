using vosita_backend_task.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace vosita_backend_task.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class vosita_backend_taskController : AbpControllerBase
{
    protected vosita_backend_taskController()
    {
        LocalizationResource = typeof(vosita_backend_taskResource);
    }
}
