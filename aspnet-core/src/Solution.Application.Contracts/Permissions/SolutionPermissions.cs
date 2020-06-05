namespace Solution.Permissions
{
    public static class SolutionPermissions
    {
        public const string GroupName = "Solution";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public const string Equipment = GroupName + ".Equipment";

        public const string EquipmentBrand = GroupName + ".EquipmentBrand";
        public const string EquipmentInspection = GroupName + ".EquipmentInspection";
        public const string EquipmentInspectionResult = GroupName + ".EquipmentInspectionResult";
        public const string EquipmentMaintenance = GroupName + ".EquipmentMaintenance";
        public const string EquipmentMaintenanceResult = GroupName + ".EquipmentMaintenanceResult";
        public const string EquipmentSparePart = GroupName + ".EquipmentSparePart";
        public const string EquipmentSparePartType = GroupName + ".EquipmentSparePartType";
        public const string EquipmentStatus = GroupName + ".EquipmentStatus";
        public const string EquipmentType = GroupName + ".EquipmentType";



        public class Enterprises
        {
            public const string Default = GroupName + ".Enterprises";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }


        public class EnterpriseAreas
        {
            public const string Default = GroupName + ".EnterpriseAreas";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class EnterpriseProductionLines
        {
            public const string Default = GroupName + ".EnterpriseProductionLines";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }


        public class EnterpriseSites
        {
            public const string Default = GroupName + ".EnterpriseSites";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
        public class EnterpriseWorkCenters
        {
            public const string Default = GroupName + ".EnterpriseWorkCenters";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class EnterpriseWorkLocations
        {
            public const string Default = GroupName + ".EnterpriseWorkLocations";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }




        public class BOM
        {
            public const string Default = GroupName + ".BOM";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Materials
        {
            public const string Default = GroupName + ".Materials";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Products
        {
            public const string Default = GroupName + ".Products";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class ProductTypes
        {
            public const string Default = GroupName + ".ProductTypes";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
