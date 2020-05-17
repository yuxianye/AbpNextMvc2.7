using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentSparePartAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentSparePartAppService _equipmentSparePartAppService;

        public EquipmentSparePartAppServiceTests()
        {
            _equipmentSparePartAppService = GetRequiredService<IEquipmentSparePartAppService>();
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
