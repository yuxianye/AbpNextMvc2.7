using System;
using Microsoft.AspNetCore.Authorization;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    [Authorize("Solution.EquipmentSparePartType")]
    public class EquipmentSparePartTypeAppService : CrudAppService<EquipmentSparePartType, EquipmentSparePartTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentSparePartTypeDto, CreateUpdateEquipmentSparePartTypeDto>,
        IEquipmentSparePartTypeAppService
    {
        public EquipmentSparePartTypeAppService(IRepository<EquipmentSparePartType, Guid> repository) : base(repository)
        {
        }
    }
}