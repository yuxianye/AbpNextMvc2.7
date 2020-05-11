using Solution.Equipments;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Solution.EntityFrameworkCore
{
    public static class SolutionDbContextModelCreatingExtensions
    {
        public static void ConfigureSolution(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(SolutionConsts.DbTablePrefix + "YourEntities", SolutionConsts.DbSchema);

            //    //...
            //});

            builder.Entity<EquipmentType>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentTypes", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });
        }
    }
}
