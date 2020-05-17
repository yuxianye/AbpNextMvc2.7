using System;
using System.Threading.Tasks;
using Solution.Equipments;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Equipments
{
    public class EquipmentRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Equipment, Guid> _equipmentRepository;

        public EquipmentRepositoryTests()
        {
            _equipmentRepository = GetRequiredService<IRepository<Equipment, Guid>>();
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
