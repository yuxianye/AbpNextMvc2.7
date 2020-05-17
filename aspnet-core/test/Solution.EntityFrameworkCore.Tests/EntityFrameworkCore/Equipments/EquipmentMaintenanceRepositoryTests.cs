using System;
using System.Threading.Tasks;
using Solution.Equipments;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Equipments
{
    public class EquipmentMaintenanceRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EquipmentMaintenance, Guid> _equipmentMaintenanceRepository;

        public EquipmentMaintenanceRepositoryTests()
        {
            _equipmentMaintenanceRepository = GetRequiredService<IRepository<EquipmentMaintenance, Guid>>();
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
