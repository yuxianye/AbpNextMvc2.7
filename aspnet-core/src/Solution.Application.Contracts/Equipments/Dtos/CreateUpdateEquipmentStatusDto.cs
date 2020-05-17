using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentStatusDto
    {
        [DisplayName("EquipmentStatusName")]
        public string Name { get; set; }

        [DisplayName("EquipmentStatusRemark")]
        public string Remark { get; set; }
    }
}