using Solution.Equipments;
using Solution.Equipments.Dtos;
using AutoMapper;

namespace Solution
{
    public class SolutionApplicationAutoMapperProfile : Profile
    {
        public SolutionApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<EquipmentType, EquipmentTypeDto>();
            CreateMap<CreateUpdateEquipmentTypeDto, EquipmentType>(MemberList.Source);
            CreateMap<EquipmentStatus, EquipmentStatusDto>();
            CreateMap<CreateUpdateEquipmentStatusDto, EquipmentStatus>(MemberList.Source);
            CreateMap<EquipmentSparePartType, EquipmentSparePartTypeDto>();
            CreateMap<CreateUpdateEquipmentSparePartTypeDto, EquipmentSparePartType>(MemberList.Source);
            CreateMap<EquipmentSparePart, EquipmentSparePartDto>();
            CreateMap<CreateUpdateEquipmentSparePartDto, EquipmentSparePart>(MemberList.Source);
            CreateMap<EquipmentMaintenanceResult, EquipmentMaintenanceResultDto>();
            CreateMap<CreateUpdateEquipmentMaintenanceResultDto, EquipmentMaintenanceResult>(MemberList.Source);
            CreateMap<EquipmentMaintenance, EquipmentMaintenanceDto>();
            CreateMap<CreateUpdateEquipmentMaintenanceDto, EquipmentMaintenance>(MemberList.Source);
            CreateMap<EquipmentInspectionResult, EquipmentInspectionResultDto>();
            CreateMap<CreateUpdateEquipmentInspectionResultDto, EquipmentInspectionResult>(MemberList.Source);
            CreateMap<EquipmentInspection, EquipmentInspectionDto>();
            CreateMap<CreateUpdateEquipmentInspectionDto, EquipmentInspection>(MemberList.Source);
            CreateMap<EquipmentBrand, EquipmentBrandDto>();
            CreateMap<CreateUpdateEquipmentBrandDto, EquipmentBrand>(MemberList.Source);
            CreateMap<Equipment, EquipmentDto>();
            CreateMap<CreateUpdateEquipmentDto, Equipment>(MemberList.Source);
        }
    }
}
