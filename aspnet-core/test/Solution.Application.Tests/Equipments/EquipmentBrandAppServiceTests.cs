using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentBrandAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentBrandAppService _equipmentBrandAppService;

        public EquipmentBrandAppServiceTests()
        {
            _equipmentBrandAppService = GetRequiredService<IEquipmentBrandAppService>();
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
