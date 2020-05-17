using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentInspectionResultAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentInspectionResultAppService _equipmentInspectionResultAppService;

        public EquipmentInspectionResultAppServiceTests()
        {
            _equipmentInspectionResultAppService = GetRequiredService<IEquipmentInspectionResultAppService>();
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
