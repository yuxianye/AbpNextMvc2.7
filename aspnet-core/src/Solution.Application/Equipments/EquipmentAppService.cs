using System;
using Microsoft.AspNetCore.Authorization;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    [Authorize("Solution.Equipment")]
    public class EquipmentAppService : CrudAppService<Equipment, EquipmentDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentDto, CreateUpdateEquipmentDto>,
        IEquipmentAppService
    {
        public EquipmentAppService(IRepository<Equipment, Guid> repository) : base(repository)
        {
        }
    }
}