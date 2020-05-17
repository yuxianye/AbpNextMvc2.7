using System;
using System.Threading.Tasks;
using Solution.Equipments;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Equipments
{
    public class EquipmentInspectionResultRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EquipmentInspectionResult, Guid> _equipmentInspectionResultRepository;

        public EquipmentInspectionResultRepositoryTests()
        {
            _equipmentInspectionResultRepository = GetRequiredService<IRepository<EquipmentInspectionResult, Guid>>();
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
