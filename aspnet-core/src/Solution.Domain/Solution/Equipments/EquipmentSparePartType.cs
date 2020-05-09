using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Equipments
{
    /// <summary>
    /// 设备备件类别
    /// </summary>
    public class EquipmentSparePartType : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        /// <summary>
        /// 设备类别名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        public Guid? TenantId { get; set; }


        public EquipmentSparePartType()
        {

        }
    }
}
