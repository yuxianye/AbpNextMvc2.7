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




        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SolutionResource>(name);
        }
    }
}
