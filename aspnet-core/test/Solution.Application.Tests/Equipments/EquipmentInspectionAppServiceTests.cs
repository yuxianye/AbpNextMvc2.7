using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentInspectionAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentInspectionAppService _equipmentInspectionAppService;

        public EquipmentInspectionAppServiceTests()
        {
            _equipmentInspectionAppService = GetRequiredService<IEquipmentInspectionAppService>();
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
