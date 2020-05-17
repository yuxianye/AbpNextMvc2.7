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

            builder.Entity<EquipmentStatus>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentStatuses", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EquipmentSparePartType>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentSparePartTypes", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EquipmentSparePart>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentSpareParts", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EquipmentMaintenanceResult>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentMaintenanceResults", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EquipmentMaintenance>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentMaintenances", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EquipmentInspectionResult>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentInspectionResults", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EquipmentInspection>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentInspections", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EquipmentBrand>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentBrands", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<Equipment>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "Equipment", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });
        }
    }
}
