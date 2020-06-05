using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Materials
{
    public class ProductTypeAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IProductTypeAppService _productTypeAppService;

        public ProductTypeAppServiceTests()
        {
            _productTypeAppService = GetRequiredService<IProductTypeAppService>();
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
