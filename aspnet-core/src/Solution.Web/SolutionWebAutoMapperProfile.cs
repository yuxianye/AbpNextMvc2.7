using Solution.Equipments.Dtos;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.Enterprise.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseArea.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseProductionLine.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseSite.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseWorkCenter.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseWorkLocation.ViewModels;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.BOM.ViewModels;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.Material.ViewModels;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.Product.ViewModels;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.ProductType.ViewModels;
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
            CreateMap<EnterpriseDto, CreateEditEnterpriseViewModel>();
            CreateMap<CreateEditEnterpriseViewModel, CreateUpdateEnterpriseDto>();
            CreateMap<EnterpriseAreaDto, CreateEditEnterpriseAreaViewModel>();
            CreateMap<CreateEditEnterpriseAreaViewModel, CreateUpdateEnterpriseAreaDto>();
            CreateMap<EnterpriseProductionLineDto, CreateEditEnterpriseProductionLineViewModel>();
            CreateMap<CreateEditEnterpriseProductionLineViewModel, CreateUpdateEnterpriseProductionLineDto>();
            CreateMap<EnterpriseSiteDto, CreateEditEnterpriseSiteViewModel>();
            CreateMap<CreateEditEnterpriseSiteViewModel, CreateUpdateEnterpriseSiteDto>();
            CreateMap<EnterpriseWorkCenterDto, CreateEditEnterpriseWorkCenterViewModel>();
            CreateMap<CreateEditEnterpriseWorkCenterViewModel, CreateUpdateEnterpriseWorkCenterDto>();
            CreateMap<EnterpriseWorkLocationDto, CreateEditEnterpriseWorkLocationViewModel>();
            CreateMap<CreateEditEnterpriseWorkLocationViewModel, CreateUpdateEnterpriseWorkLocationDto>();
            CreateMap<BOMDto, CreateEditBOMViewModel>();
            CreateMap<CreateEditBOMViewModel, CreateUpdateBOMDto>();
            CreateMap<MaterialDto, CreateEditMaterialViewModel>();
            CreateMap<CreateEditMaterialViewModel, CreateUpdateMaterialDto>();
            CreateMap<ProductDto, CreateEditProductViewModel>();
            CreateMap<CreateEditProductViewModel, CreateUpdateProductDto>();
            CreateMap<ProductTypeDto, CreateEditProductTypeViewModel>();
            CreateMap<CreateEditProductTypeViewModel, CreateUpdateProductTypeDto>();
        }
    }
}
