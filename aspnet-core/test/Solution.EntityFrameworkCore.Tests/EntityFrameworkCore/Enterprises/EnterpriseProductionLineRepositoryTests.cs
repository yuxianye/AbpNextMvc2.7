using System;
using System.Threading.Tasks;
using Solution.Enterprises;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Enterprises
{
    public class EnterpriseProductionLineRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EnterpriseProductionLine, Guid> _enterpriseProductionLineRepository;

        public EnterpriseProductionLineRepositoryTests()
        {
            _enterpriseProductionLineRepository = GetRequiredService<IRepository<EnterpriseProductionLine, Guid>>();
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
