﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Equipments
{
    /// <summary>
    /// 设备实体
    /// </summary>
    public class Equipment : AuditedAggregateRoot<Guid>, IMultiTenant
    {

        /// <summary>
        /// 设备类别Id
        /// </summary>
        public Guid EquipmentTypeId { get; set; }

        /// <summary>
        /// 设备品牌Id
        /// </summary>
        public Guid EquipmentBrandId { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        public string EquipmentCode { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 出厂日期
        /// </summary>
        public DateTime ManufactureDate { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public Guid? EquipmentStatusId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        public Guid? TenantId { get; set; }


        public Equipment()
        {

        }

    }

}