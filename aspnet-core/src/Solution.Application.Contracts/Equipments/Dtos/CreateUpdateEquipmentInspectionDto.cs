using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentInspectionDto
    {
        [DisplayName("EquipmentInspectionEquipmentId")]
        public Guid EquipmentId { get; set; }

        [DisplayName("EquipmentInspectionInspectionTime")]
        public DateTime InspectionTime { get; set; }

        [DisplayName("EquipmentInspectionEquipmentInspectionResultId")]
        public Guid EquipmentInspectionResultId { get; set; }

        [DisplayName("EquipmentInspectionProblem")]
        public string Problem { get; set; }

        [DisplayName("EquipmentInspectionCause")]
        public string Cause { get; set; }

        [DisplayName("EquipmentInspectionSolution")]
        public string Solution { get; set; }

        [DisplayName("EquipmentInspectionRemark")]
        public string Remark { get; set; }
    }
}