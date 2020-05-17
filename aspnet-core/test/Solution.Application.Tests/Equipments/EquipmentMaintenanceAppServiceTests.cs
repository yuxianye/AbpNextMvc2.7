using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentMaintenanceAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentMaintenanceAppService _equipmentMaintenanceAppService;

        public EquipmentMaintenanceAppServiceTests()
        {
            _equipmentMaintenanceAppService = GetRequiredService<IEquipmentMaintenanceAppService>();
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
