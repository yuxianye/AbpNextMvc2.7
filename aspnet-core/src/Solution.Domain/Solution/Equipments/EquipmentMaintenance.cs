using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Equipments
{
    /// <summary>
    /// 设备维修实体
    /// </summary>
    public class EquipmentMaintenance : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 设备Id
        /// </summary>
        public Guid EquipmentId { get; set; }

        /// <summary>
        /// 设备存在问题
        /// </summary>
        public string Problem { get; set; }

        /// <summary>
        /// 设备存在问题的原因
        /// </summary>
        public string Cause { get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        public string Solution { get; set; }

        /// <summary>
        /// 维护实际开始时间
        /// </summary>
        public DateTime ActualStartTime { get; set; }

        /// <summary>
        /// 维护实际完成时间
        /// </summary>
        public DateTime ActualFinishTime { get; set; }

        /// <summary>
        /// 维护消耗资源
        /// </summary>
        public string Consumable { get; set; }

        /// <summary>
        /// 维护责任人 维保工程师
        /// </summary>
        public string ResponsiblePerson { get; set; }

        /// <summary>
        /// 维修时间
        /// </summary>
        public DateTime MaintenanceTime { get; set; }

        /// <summary>
        /// 维修结果
        /// </summary>
        public Guid EquipmentMaintenanceResultId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }

}
