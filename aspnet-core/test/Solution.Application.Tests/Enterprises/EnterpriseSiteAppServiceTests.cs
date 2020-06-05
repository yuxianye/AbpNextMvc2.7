using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Enterprises
{
    public class EnterpriseSiteAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEnterpriseSiteAppService _enterpriseSiteAppService;

        public EnterpriseSiteAppServiceTests()
        {
            _enterpriseSiteAppService = GetRequiredService<IEnterpriseSiteAppService>();
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
