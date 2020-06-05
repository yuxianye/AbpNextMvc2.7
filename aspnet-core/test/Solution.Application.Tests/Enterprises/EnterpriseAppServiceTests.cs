using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Enterprises
{
    public class EnterpriseAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEnterpriseAppService _enterpriseAppService;

        public EnterpriseAppServiceTests()
        {
            _enterpriseAppService = GetRequiredService<IEnterpriseAppService>();
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
