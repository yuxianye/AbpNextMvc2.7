using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Public
{
    /// <summary>
    /// 质量检查
    /// </summary>
    public class QualityInspect : AuditedEntity<Guid>
    {

        /// <summary>
        /// 检查时间
        /// </summary>
        public DateTime InspectTime { get; set; }

        /// <summary>
        /// 工序名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
