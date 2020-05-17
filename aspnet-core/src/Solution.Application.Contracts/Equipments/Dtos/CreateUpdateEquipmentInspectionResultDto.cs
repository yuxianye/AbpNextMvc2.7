using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentInspectionResultDto
    {
        [DisplayName("EquipmentInspectionResultName")]
        public string Name { get; set; }

        [DisplayName("EquipmentInspectionResultRemark")]
        public string Remark { get; set; }
    }
}