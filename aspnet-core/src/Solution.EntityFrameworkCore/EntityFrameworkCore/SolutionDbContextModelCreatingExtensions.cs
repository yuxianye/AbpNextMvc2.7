using Solution.Materials;
using Solution.Enterprises;
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
                b.Property(x => x.Name).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<EquipmentStatus>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentStatuses", SolutionConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<EquipmentSparePartType>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentSparePartTypes", SolutionConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<EquipmentSparePart>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentSpareParts", SolutionConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<EquipmentMaintenanceResult>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentMaintenanceResults", SolutionConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<EquipmentMaintenance>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentMaintenances", SolutionConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Problem).IsRequired().HasMaxLength(Const.CommonStringLength256);
                b.Property(x => x.Cause).IsRequired().HasMaxLength(Const.CommonStringLength256);
                b.Property(x => x.Solution).IsRequired().HasMaxLength(Const.CommonStringLength256);
                b.Property(x => x.Consumable).IsRequired().HasMaxLength(Const.CommonStringLength256);
                b.Property(x => x.ResponsiblePerson).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<EquipmentInspectionResult>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentInspectionResults", SolutionConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<EquipmentInspection>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentInspections", SolutionConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.InspectPerson).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Problem).IsRequired().HasMaxLength(Const.CommonStringLength256);
                b.Property(x => x.Cause).IsRequired().HasMaxLength(Const.CommonStringLength256);
                b.Property(x => x.Solution).IsRequired().HasMaxLength(Const.CommonStringLength256);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<EquipmentBrand>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EquipmentBrands", SolutionConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<Equipment>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "Equipment", SolutionConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Code).IsRequired().HasMaxLength(Const.CodeLength);
                b.Property(x => x.Name).IsRequired().HasMaxLength(Const.NameLength);
                b.Property(x => x.Specification).IsRequired().HasMaxLength(Const.CommonStringLength64);
                b.Property(x => x.Remark).HasMaxLength(Const.RemarkLength);
                /* Configure more properties here */
            });

            builder.Entity<Enterprise>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "Enterprises", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EnterpriseArea>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EnterpriseAreas", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EnterpriseProductionLine>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EnterpriseProductionLines", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EnterpriseSite>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EnterpriseSites", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EnterpriseWorkCenter>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EnterpriseWorkCenters", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<EnterpriseWorkLocation>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "EnterpriseWorkLocations", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<BOM>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "BOMs", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<Material>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "Materials", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<Product>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "Products", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });

            builder.Entity<ProductType>(b =>
            {
                b.ToTable(SolutionConsts.DbTablePrefix + "ProductTypes", SolutionConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });
        }
    }
}
