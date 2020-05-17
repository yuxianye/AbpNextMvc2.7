using System;
using Microsoft.AspNetCore.Authorization;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    [Authorize("Solution.EquipmentBrand")]
    public class EquipmentBrandAppService : CrudAppService<EquipmentBrand, EquipmentBrandDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentBrandDto, CreateUpdateEquipmentBrandDto>,
        IEquipmentBrandAppService
    {
        public EquipmentBrandAppService(IRepository<EquipmentBrand, Guid> repository) : base(repository)
        {
        }
    }
}