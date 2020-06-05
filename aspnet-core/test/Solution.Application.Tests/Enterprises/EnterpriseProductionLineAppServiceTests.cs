using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Enterprises
{
    public class EnterpriseProductionLineAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEnterpriseProductionLineAppService _enterpriseProductionLineAppService;

        public EnterpriseProductionLineAppServiceTests()
        {
            _enterpriseProductionLineAppService = GetRequiredService<IEnterpriseProductionLineAppService>();
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
