using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Enterprises
{
    public class EnterpriseWorkCenterAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEnterpriseWorkCenterAppService _enterpriseWorkCenterAppService;

        public EnterpriseWorkCenterAppServiceTests()
        {
            _enterpriseWorkCenterAppService = GetRequiredService<IEnterpriseWorkCenterAppService>();
        }

        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
