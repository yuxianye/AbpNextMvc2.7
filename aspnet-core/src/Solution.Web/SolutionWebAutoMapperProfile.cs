using Solution.Equipments.Dtos;
using AutoMapper;

namespace Solution.Web
{
    public class SolutionWebAutoMapperProfile : Profile
    {
        public SolutionWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<EquipmentTypeDto, CreateUpdateEquipmentTypeDto>();
            CreateMap<EquipmentStatusDto, CreateUpdateEquipmentStatusDto>();
            CreateMap<EquipmentSparePartTypeDto, CreateUpdateEquipmentSparePartTypeDto>();
            CreateMap<EquipmentSparePartDto, CreateUpdateEquipmentSparePartDto>();
            CreateMap<EquipmentMaintenanceResultDto, CreateUpdateEquipmentMaintenanceResultDto>();
            CreateMap<EquipmentMaintenanceDto, CreateUpdateEquipmentMaintenanceDto>();
            CreateMap<EquipmentInspectionResultDto, CreateUpdateEquipmentInspectionResultDto>();
            CreateMap<EquipmentInspectionDto, CreateUpdateEquipmentInspectionDto>();
            CreateMap<EquipmentBrandDto, CreateUpdateEquipmentBrandDto>();
            CreateMap<EquipmentDto, CreateUpdateEquipmentDto>();
        }
    }
}
