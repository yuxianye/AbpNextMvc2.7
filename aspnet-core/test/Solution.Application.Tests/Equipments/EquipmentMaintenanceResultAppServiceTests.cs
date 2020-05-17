using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentMaintenanceResultAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentMaintenanceResultAppService _equipmentMaintenanceResultAppService;

        public EquipmentMaintenanceResultAppServiceTests()
        {
            _equipmentMaintenanceResultAppService = GetRequiredService<IEquipmentMaintenanceResultAppService>();
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
