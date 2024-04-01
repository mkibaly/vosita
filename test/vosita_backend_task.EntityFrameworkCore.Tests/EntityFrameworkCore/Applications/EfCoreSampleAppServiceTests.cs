using vosita_backend_task.Samples;
using Xunit;

namespace vosita_backend_task.EntityFrameworkCore.Applications;

[Collection(vosita_backend_taskTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<vosita_backend_taskEntityFrameworkCoreTestModule>
{

}
