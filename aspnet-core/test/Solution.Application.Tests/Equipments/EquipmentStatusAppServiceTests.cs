using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Equipments
{
    public class EquipmentStatusAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IEquipmentStatusAppService _equipmentStatusAppService;

        public EquipmentStatusAppServiceTests()
        {
            _equipmentStatusAppService = GetRequiredService<IEquipmentStatusAppService>();
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
