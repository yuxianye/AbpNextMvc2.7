using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Materials
{
    public class BOMAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IBOMAppService _bOMAppService;

        public BOMAppServiceTests()
        {
            _bOMAppService = GetRequiredService<IBOMAppService>();
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
