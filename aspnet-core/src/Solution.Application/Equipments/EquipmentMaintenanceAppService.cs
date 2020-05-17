using System;
using Microsoft.AspNetCore.Authorization;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    [Authorize("Solution.EquipmentMaintenance")]
    public class EquipmentMaintenanceAppService : CrudAppService<EquipmentMaintenance, EquipmentMaintenanceDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentMaintenanceDto, CreateUpdateEquipmentMaintenanceDto>,
        IEquipmentMaintenanceAppService
    {
        public EquipmentMaintenanceAppService(IRepository<EquipmentMaintenance, Guid> repository) : base(repository)
        {
        }
    }
}