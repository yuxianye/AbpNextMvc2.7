using System;
using System.Threading.Tasks;
using Solution.Equipments;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Equipments
{
    public class EquipmentSparePartTypeRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EquipmentSparePartType, Guid> _equipmentSparePartTypeRepository;

        public EquipmentSparePartTypeRepositoryTests()
        {
            _equipmentSparePartTypeRepository = GetRequiredService<IRepository<EquipmentSparePartType, Guid>>();
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
