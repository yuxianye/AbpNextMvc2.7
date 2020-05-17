using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentMaintenanceResultDto
    {
        [DisplayName("EquipmentMaintenanceResultName")]
        public string Name { get; set; }

        [DisplayName("EquipmentMaintenanceResultRemark")]
        public string Remark { get; set; }
    }
}