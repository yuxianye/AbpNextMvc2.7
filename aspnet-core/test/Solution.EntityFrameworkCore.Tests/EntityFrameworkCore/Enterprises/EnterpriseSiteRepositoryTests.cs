using System;
using System.Threading.Tasks;
using Solution.Enterprises;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Enterprises
{
    public class EnterpriseSiteRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<EnterpriseSite, Guid> _enterpriseSiteRepository;

        public EnterpriseSiteRepositoryTests()
        {
            _enterpriseSiteRepository = GetRequiredService<IRepository<EnterpriseSite, Guid>>();
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
