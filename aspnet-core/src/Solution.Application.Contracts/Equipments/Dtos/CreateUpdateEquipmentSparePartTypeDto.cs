using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentSparePartTypeDto
    {
        [DisplayName("EquipmentSparePartTypeName")]
        public string Name { get; set; }

        [DisplayName("EquipmentSparePartTypeRemark")]
        public string Remark { get; set; }
    }
}