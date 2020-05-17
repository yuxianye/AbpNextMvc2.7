using System;
using Microsoft.AspNetCore.Authorization;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    [Authorize("Solution.EquipmentSparePart")]
    public class EquipmentSparePartAppService : CrudAppService<EquipmentSparePart, EquipmentSparePartDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentSparePartDto, CreateUpdateEquipmentSparePartDto>,
        IEquipmentSparePartAppService
    {
        public EquipmentSparePartAppService(IRepository<EquipmentSparePart, Guid> repository) : base(repository)
        {
        }
    }
}