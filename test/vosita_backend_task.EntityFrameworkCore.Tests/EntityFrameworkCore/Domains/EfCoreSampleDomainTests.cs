using vosita_backend_task.Samples;
using Xunit;

namespace vosita_backend_task.EntityFrameworkCore.Domains;

[Collection(vosita_backend_taskTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<vosita_backend_taskEntityFrameworkCoreTestModule>
{

}
