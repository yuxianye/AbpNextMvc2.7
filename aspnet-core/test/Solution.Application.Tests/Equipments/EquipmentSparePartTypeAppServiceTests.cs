using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentSparePartTypeAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentSparePartTypeAppService _equipmentSparePartTypeAppService;

        public EquipmentSparePartTypeAppServiceTests()
        {
            _equipmentSparePartTypeAppService = GetRequiredService<IEquipmentSparePartTypeAppService>();
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
