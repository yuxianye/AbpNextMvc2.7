using System;
using System.Threading.Tasks;
using Solution.Enterprises;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Enterprises
{
    public class EnterpriseAreaRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EnterpriseArea, Guid> _enterpriseAreaRepository;

        public EnterpriseAreaRepositoryTests()
        {
            _enterpriseAreaRepository = GetRequiredService<IRepository<EnterpriseArea, Guid>>();
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
