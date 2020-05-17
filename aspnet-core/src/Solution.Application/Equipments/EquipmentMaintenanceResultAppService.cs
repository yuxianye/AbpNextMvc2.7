using System;
using Microsoft.AspNetCore.Authorization;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    [Authorize("Solution.EquipmentMaintenanceResult")]
    public class EquipmentMaintenanceResultAppService : CrudAppService<EquipmentMaintenanceResult, EquipmentMaintenanceResultDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentMaintenanceResultDto, CreateUpdateEquipmentMaintenanceResultDto>,
        IEquipmentMaintenanceResultAppService
    {
        public EquipmentMaintenanceResultAppService(IRepository<EquipmentMaintenanceResult, Guid> repository) : base(repository)
        {
        }
    }
}