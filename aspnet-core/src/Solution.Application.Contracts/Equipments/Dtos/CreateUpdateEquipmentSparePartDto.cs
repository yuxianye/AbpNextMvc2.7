using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentSparePartDto
    {
        [DisplayName("EquipmentSparePartEquipmentSparePartTypeId")]
        public Guid? EquipmentSparePartTypeId { get; set; }

        [DisplayName("EquipmentSparePartName")]
        public string Name { get; set; }

        [DisplayName("EquipmentSparePartRemark")]
        public string Remark { get; set; }
    }
}