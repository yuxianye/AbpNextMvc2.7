using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Materials
{
    public class MaterialAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IMaterialAppService _materialAppService;

        public MaterialAppServiceTests()
        {
            _materialAppService = GetRequiredService<IMaterialAppService>();
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
