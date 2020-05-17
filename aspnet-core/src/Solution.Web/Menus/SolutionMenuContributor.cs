using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Solution.Localization;
using Solution.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Solution.Web.Menus
{
    public class SolutionMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<SolutionResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Solution.Home", l["Menu:Home"], "/"));



            context.Menu.AddItem(
    new ApplicationMenuItem("Equipment", l["Menu:Equipment"])
        .AddItem(new ApplicationMenuItem("EquipmentType", l["Menu:EquipmentType"], "/Equipments/EquipmentType"))
        .AddItem(new ApplicationMenuItem("EquipmentStatus", l["Menu:EquipmentStatus"], "/Equipments/EquipmentStatus"))
        .AddItem(new ApplicationMenuItem("EquipmentSparePartType", l["Menu:EquipmentSparePartType"], "/Equipments/EquipmentSparePartType"))
        .AddItem(new ApplicationMenuItem("EquipmentSparePart", l["Menu:EquipmentSparePart"], "/Equipments/EquipmentSparePart"))
        .AddItem(new ApplicationMenuItem("EquipmentMaintenanceResult", l["Menu:EquipmentMaintenanceResult"], "/Equipments/EquipmentMaintenanceResult"))
        .AddItem(new ApplicationMenuItem("EquipmentMaintenance", l["Menu:EquipmentMaintenance"], "/Equipments/EquipmentMaintenance"))
        .AddItem(new ApplicationMenuItem("EquipmentInspectionResult", l["Menu:EquipmentInspectionResult"], "/Equipments/EquipmentInspectionResult"))
        .AddItem(new ApplicationMenuItem("EquipmentInspection", l["Menu:EquipmentInspection"], "/Equipments/EquipmentInspection"))
        .AddItem(new ApplicationMenuItem("EquipmentBrand", l["Menu:EquipmentBrand"], "/Equipments/EquipmentBrand"))
        .AddItem(new ApplicationMenuItem("Equipment", l["Menu:Equipment"], "/Equipments/Equipment"))
);

        }
    }
}
