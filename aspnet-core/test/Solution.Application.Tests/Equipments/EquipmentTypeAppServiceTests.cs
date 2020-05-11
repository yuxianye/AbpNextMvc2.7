using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentTypeAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentTypeAppService _equipmentTypeAppService;

        public EquipmentTypeAppServiceTests()
        {
            _equipmentTypeAppService = GetRequiredService<IEquipmentTypeAppService>();
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
