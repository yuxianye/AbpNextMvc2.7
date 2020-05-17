using System;
using System.Threading.Tasks;
using Solution.Equipments;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Equipments
{
    public class EquipmentStatusRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EquipmentStatus, Guid> _equipmentStatusRepository;

        public EquipmentStatusRepositoryTests()
        {
            _equipmentStatusRepository = GetRequiredService<IRepository<EquipmentStatus, Guid>>();
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
