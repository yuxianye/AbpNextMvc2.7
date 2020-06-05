using System;
using System.Threading.Tasks;
using Solution.Materials;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Materials
{
    public class BOMRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<BOM, Guid> _bOMRepository;

        public BOMRepositoryTests()
        {
            _bOMRepository = GetRequiredService<IRepository<BOM, Guid>>();
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
