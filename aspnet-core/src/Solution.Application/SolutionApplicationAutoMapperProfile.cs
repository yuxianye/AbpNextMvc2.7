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
        }
    }
}
