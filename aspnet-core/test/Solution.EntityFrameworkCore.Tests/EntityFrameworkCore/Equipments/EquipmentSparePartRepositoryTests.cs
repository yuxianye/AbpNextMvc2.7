using System;
using System.Threading.Tasks;
using Solution.Equipments;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Equipments
{
    public class EquipmentSparePartRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EquipmentSparePart, Guid> _equipmentSparePartRepository;

        public EquipmentSparePartRepositoryTests()
        {
            _equipmentSparePartRepository = GetRequiredService<IRepository<EquipmentSparePart, Guid>>();
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
