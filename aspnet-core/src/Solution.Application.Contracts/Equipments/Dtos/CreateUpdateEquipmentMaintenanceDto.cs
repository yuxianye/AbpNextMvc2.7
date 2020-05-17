using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentMaintenanceDto
    {
        [DisplayName("EquipmentMaintenanceEquipmentId")]
        public Guid EquipmentId { get; set; }

        [DisplayName("EquipmentMaintenanceProblem")]
        public string Problem { get; set; }

        [DisplayName("EquipmentMaintenanceCause")]
        public string Cause { get; set; }

        [DisplayName("EquipmentMaintenanceSolution")]
        public string Solution { get; set; }

        [DisplayName("EquipmentMaintenanceActualStartTime")]
        public DateTime ActualStartTime { get; set; }

        [DisplayName("EquipmentMaintenanceActualFinishTime")]
        public DateTime ActualFinishTime { get; set; }

        [DisplayName("EquipmentMaintenanceConsumable")]
        public string Consumable { get; set; }

        [DisplayName("EquipmentMaintenanceResponsiblePerson")]
        public string ResponsiblePerson { get; set; }

        [DisplayName("EquipmentMaintenanceMaintenanceTime")]
        public DateTime MaintenanceTime { get; set; }

        [DisplayName("EquipmentMaintenanceEquipmentMaintenanceResultId")]
        public Guid EquipmentMaintenanceResultId { get; set; }

        [DisplayName("EquipmentMaintenanceRemark")]
        public string Remark { get; set; }
    }
}