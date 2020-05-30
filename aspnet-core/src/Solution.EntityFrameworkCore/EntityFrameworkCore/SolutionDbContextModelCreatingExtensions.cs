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
        }
    }
}
