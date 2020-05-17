using System;
using Microsoft.AspNetCore.Authorization;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    [Authorize("Solution.EquipmentStatus")]
    public class EquipmentStatusAppService : CrudAppService<EquipmentStatus, EquipmentStatusDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentStatusDto, CreateUpdateEquipmentStatusDto>,
        IEquipmentStatusAppService
    {
        public EquipmentStatusAppService(IRepository<EquipmentStatus, Guid> repository) : base(repository)
        {
        }
    }
}