using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Enterprises
{
    /// <summary>
    /// 生产线
    /// </summary>
    public class EnterpriseProductionLine : AuditedEntity<Guid>
    {

        /// <summary>
        /// 所属车间
        /// </summary>
        public Guid EnterpriseAreaId { get; set; }

        /// <summary>
        /// 产线名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产线负责人、管理人
        /// </summary>
        public string Manager { get; set; }

        /// <summary>
        /// 产线电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
