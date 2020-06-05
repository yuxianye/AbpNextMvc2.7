using System;
using System.Threading.Tasks;
using Solution.Materials;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Materials
{
    public class ProductTypeRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<ProductType, Guid> _productTypeRepository;

        public ProductTypeRepositoryTests()
        {
            _productTypeRepository = GetRequiredService<IRepository<ProductType, Guid>>();
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
