using System;
using System.Threading.Tasks;
using Solution.Materials;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Materials
{
    public class ProductRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductRepositoryTests()
        {
            _productRepository = GetRequiredService<IRepository<Product, Guid>>();
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
