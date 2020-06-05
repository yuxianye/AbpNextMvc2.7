using System;
using System.Threading.Tasks;
using Solution.Enterprises;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Enterprises
{
    public class EnterpriseWorkCenterRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EnterpriseWorkCenter, Guid> _enterpriseWorkCenterRepository;

        public EnterpriseWorkCenterRepositoryTests()
        {
            _enterpriseWorkCenterRepository = GetRequiredService<IRepository<EnterpriseWorkCenter, Guid>>();
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
