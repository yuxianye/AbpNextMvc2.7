using System;
using System.Threading.Tasks;
using Solution.Enterprises;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Enterprises
{
    public class EnterpriseWorkLocationRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EnterpriseWorkLocation, Guid> _enterpriseWorkLocationRepository;

        public EnterpriseWorkLocationRepositoryTests()
        {
            _enterpriseWorkLocationRepository = GetRequiredService<IRepository<EnterpriseWorkLocation, Guid>>();
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
