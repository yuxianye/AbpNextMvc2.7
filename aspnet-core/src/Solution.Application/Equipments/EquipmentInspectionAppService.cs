using System;
using Microsoft.AspNetCore.Authorization;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    [Authorize("Solution.EquipmentInspection")]
    public class EquipmentInspectionAppService : CrudAppService<EquipmentInspection, EquipmentInspectionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentInspectionDto, CreateUpdateEquipmentInspectionDto>,
        IEquipmentInspectionAppService
    {
        public EquipmentInspectionAppService(IRepository<EquipmentInspection, Guid> repository) : base(repository)
        {
        }
    }
}