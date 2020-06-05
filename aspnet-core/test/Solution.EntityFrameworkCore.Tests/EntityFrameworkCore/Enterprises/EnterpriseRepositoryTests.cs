using System;
using System.Threading.Tasks;
using Solution.Enterprises;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Enterprises
{
    public class EnterpriseRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Enterprise, Guid> _enterpriseRepository;

        public EnterpriseRepositoryTests()
        {
            _enterpriseRepository = GetRequiredService<IRepository<Enterprise, Guid>>();
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
