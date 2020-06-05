using Solution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Solution.Permissions
{
    public class SolutionPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SolutionPermissions.GroupName, L("Solution"));

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SolutionPermissions.MyPermission1, L("Permission:MyPermission1"));


            myGroup.AddPermission(SolutionPermissions.Equipment, L("Permission:Equipment"));
            myGroup.AddPermission(SolutionPermissions.EquipmentBrand, L("Permission:EquipmentBrand"));
            myGroup.AddPermission(SolutionPermissions.EquipmentInspection, L("Permission:EquipmentInspection"));
            myGroup.AddPermission(SolutionPermissions.EquipmentInspectionResult, L("Permission:EquipmentInspectionResult"));
            myGroup.AddPermission(SolutionPermissions.EquipmentMaintenance, L("Permission:EquipmentMaintenance"));
            myGroup.AddPermission(SolutionPermissions.EquipmentMaintenanceResult, L("Permission:EquipmentMaintenanceResult"));
            myGroup.AddPermission(SolutionPermissions.EquipmentSparePart, L("Permission:EquipmentSparePart"));
            myGroup.AddPermission(SolutionPermissions.EquipmentSparePartType, L("Permission:EquipmentSparePartType"));
            myGroup.AddPermission(SolutionPermissions.EquipmentStatus, L("Permission:EquipmentStatus"));
            myGroup.AddPermission(SolutionPermissions.EquipmentType, L("Permission:EquipmentType"));





            var enterprisePermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterprisePermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterprisePermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterprisePermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseAreaPermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseAreaPermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseAreaPermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseAreaPermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseProductionLinePermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseProductionLinePermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseProductionLinePermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseProductionLinePermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseSitePermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseSitePermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseSitePermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseSitePermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseWorkCenterPermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseWorkCenterPermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseWorkCenterPermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseWorkCenterPermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseWorkLocationPermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseWorkLocationPermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseWorkLocationPermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseWorkLocationPermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var bOMPermission = myGroup.AddPermission(SolutionPermissions.Materials.Default, L("Permission:Materials"));
            bOMPermission.AddChild(SolutionPermissions.Materials.Create, L("Permission:Create"));
            bOMPermission.AddChild(SolutionPermissions.Materials.Update, L("Permission:Update"));
            bOMPermission.AddChild(SolutionPermissions.Materials.Delete, L("Permission:Delete"));

            var materialPermission = myGroup.AddPermission(SolutionPermissions.Materials.Default, L("Permission:Materials"));
            materialPermission.AddChild(SolutionPermissions.Materials.Create, L("Permission:Create"));
            materialPermission.AddChild(SolutionPermissions.Materials.Update, L("Permission:Update"));
            materialPermission.AddChild(SolutionPermissions.Materials.Delete, L("Permission:Delete"));

            var productPermission = myGroup.AddPermission(SolutionPermissions.Materials.Default, L("Permission:Materials"));
            productPermission.AddChild(SolutionPermissions.Materials.Create, L("Permission:Create"));
            productPermission.AddChild(SolutionPermissions.Materials.Update, L("Permission:Update"));
            productPermission.AddChild(SolutionPermissions.Materials.Delete, L("Permission:Delete"));

            var productTypePermission = myGroup.AddPermission(SolutionPermissions.Materials.Default, L("Permission:Materials"));
            productTypePermission.AddChild(SolutionPermissions.Materials.Create, L("Permission:Create"));
            productTypePermission.AddChild(SolutionPermissions.Materials.Update, L("Permission:Update"));
            productTypePermission.AddChild(SolutionPermissions.Materials.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SolutionResource>(name);
        }
    }
}
