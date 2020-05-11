using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentTypeDto
    {
        [DisplayName("EquipmentTypeName")]
        public string Name { get; set; }

        [DisplayName("EquipmentTypeRemark")]
        public string Remark { get; set; }
    }
}