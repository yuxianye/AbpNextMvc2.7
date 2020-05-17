using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentBrandDto
    {
        [DisplayName("EquipmentBrandName")]
        public string Name { get; set; }

        [DisplayName("EquipmentBrandRemark")]
        public string Remark { get; set; }
    }
}