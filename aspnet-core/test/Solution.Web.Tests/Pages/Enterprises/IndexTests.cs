
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Solution.Pages.Enterprises
{
    public class Index_Tests : SolutionWebTestBase
    {
        [Fact]
        public async Task Index_Page_Test()
        {
            // Arrange

            // Act
            var response = await GetResponseAsStringAsync("/EnterpriseWorkLocation");

            // Assert
            response.ShouldNotBeNull();
        }
    }
}
