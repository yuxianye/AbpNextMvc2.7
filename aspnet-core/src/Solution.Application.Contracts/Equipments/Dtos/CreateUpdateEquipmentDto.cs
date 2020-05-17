using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentDto
    {
        [DisplayName("EquipmentEquipmentTypeId")]
        public Guid EquipmentTypeId { get; set; }

        [DisplayName("EquipmentEquipmentBrandId")]
        public Guid EquipmentBrandId { get; set; }

        [DisplayName("EquipmentEquipmentCode")]
        public string EquipmentCode { get; set; }

        [DisplayName("EquipmentName")]
        public string Name { get; set; }

        [DisplayName("EquipmentSpecification")]
        public string Specification { get; set; }

        [DisplayName("EquipmentManufactureDate")]
        public DateTime ManufactureDate { get; set; }

        [DisplayName("EquipmentEquipmentStatusId")]
        public Guid? EquipmentStatusId { get; set; }

        [DisplayName("EquipmentRemark")]
        public string Remark { get; set; }
    }
}