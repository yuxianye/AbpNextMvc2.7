using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentAppService _equipmentAppService;

        public EquipmentAppServiceTests()
        {
            _equipmentAppService = GetRequiredService<IEquipmentAppService>();
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
