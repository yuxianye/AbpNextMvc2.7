using System;
using System.Threading.Tasks;
using Solution.Equipments;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Equipments
{
    public class EquipmentMaintenanceResultRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EquipmentMaintenanceResult, Guid> _equipmentMaintenanceResultRepository;

        public EquipmentMaintenanceResultRepositoryTests()
        {
            _equipmentMaintenanceResultRepository = GetRequiredService<IRepository<EquipmentMaintenanceResult, Guid>>();
        }

        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
    }
}
