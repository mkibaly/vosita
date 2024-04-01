using System;
using System.Collections.Generic;
using System.Text;
using vosita_backend_task.Localization;
using Volo.Abp.Application.Services;

namespace vosita_backend_task;

/* Inherit your application services from this class.
 */
public abstract class vosita_backend_taskAppService : ApplicationService
{
    protected vosita_backend_taskAppService()
    {
        LocalizationResource = typeof(vosita_backend_taskResource);
    }
}
