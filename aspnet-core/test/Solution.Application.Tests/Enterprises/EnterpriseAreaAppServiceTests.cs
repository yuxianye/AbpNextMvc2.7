using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Enterprises
{
    public class EnterpriseAreaAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEnterpriseAreaAppService _enterpriseAreaAppService;

        public EnterpriseAreaAppServiceTests()
        {
            _enterpriseAreaAppService = GetRequiredService<IEnterpriseAreaAppService>();
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
