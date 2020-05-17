using System;
using Microsoft.AspNetCore.Authorization;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    [Authorize("Solution.EquipmentInspection")]
    public class EquipmentInspectionResultAppService : CrudAppService<EquipmentInspectionResult, EquipmentInspectionResultDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentInspectionResultDto, CreateUpdateEquipmentInspectionResultDto>,
        IEquipmentInspectionResultAppService
    {
        public EquipmentInspectionResultAppService(IRepository<EquipmentInspectionResult, Guid> repository) : base(repository)
        {
        }
    }
}