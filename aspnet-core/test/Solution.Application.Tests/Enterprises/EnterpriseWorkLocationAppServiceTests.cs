using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Enterprises
{
    public class EnterpriseWorkLocationAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEnterpriseWorkLocationAppService _enterpriseWorkLocationAppService;

        public EnterpriseWorkLocationAppServiceTests()
        {
            _enterpriseWorkLocationAppService = GetRequiredService<IEnterpriseWorkLocationAppService>();
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
