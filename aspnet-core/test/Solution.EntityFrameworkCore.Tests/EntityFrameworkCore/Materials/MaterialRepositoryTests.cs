using System;
using System.Threading.Tasks;
using Solution.Materials;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Materials
{
    public class MaterialRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Material, Guid> _materialRepository;

        public MaterialRepositoryTests()
        {
            _materialRepository = GetRequiredService<IRepository<Material, Guid>>();
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
