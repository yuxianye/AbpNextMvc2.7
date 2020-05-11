using System;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentTypeAppService : CrudAppService<EquipmentType, EquipmentTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentTypeDto, CreateUpdateEquipmentTypeDto>,
        IEquipmentTypeAppService
    {
        public EquipmentTypeAppService(IRepository<EquipmentType, Guid> repository) : base(repository)
        {
        }
    }
}