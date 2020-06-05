using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Materials;
using Solution.Materials.Dtos;
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
            CreateMap<Enterprise, EnterpriseDto>();
            CreateMap<CreateUpdateEnterpriseDto, Enterprise>(MemberList.Source);
            CreateMap<EnterpriseArea, EnterpriseAreaDto>();
            CreateMap<CreateUpdateEnterpriseAreaDto, EnterpriseArea>(MemberList.Source);
            CreateMap<EnterpriseProductionLine, EnterpriseProductionLineDto>();
            CreateMap<CreateUpdateEnterpriseProductionLineDto, EnterpriseProductionLine>(MemberList.Source);
            CreateMap<EnterpriseSite, EnterpriseSiteDto>();
            CreateMap<CreateUpdateEnterpriseSiteDto, EnterpriseSite>(MemberList.Source);
            CreateMap<EnterpriseWorkCenter, EnterpriseWorkCenterDto>();
            CreateMap<CreateUpdateEnterpriseWorkCenterDto, EnterpriseWorkCenter>(MemberList.Source);
            CreateMap<EnterpriseWorkLocation, EnterpriseWorkLocationDto>();
            CreateMap<CreateUpdateEnterpriseWorkLocationDto, EnterpriseWorkLocation>(MemberList.Source);
            CreateMap<BOM, BOMDto>();
            CreateMap<CreateUpdateBOMDto, BOM>(MemberList.Source);
            CreateMap<Material, MaterialDto>();
            CreateMap<CreateUpdateMaterialDto, Material>(MemberList.Source);
            CreateMap<Product, ProductDto>();
            CreateMap<CreateUpdateProductDto, Product>(MemberList.Source);
            CreateMap<ProductType, ProductTypeDto>();
            CreateMap<CreateUpdateProductTypeDto, ProductType>(MemberList.Source);
        }
    }
}
