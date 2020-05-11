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
        }
    }
}
