using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentBrand
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateUpdateEquipmentBrandDto EquipmentBrand { get; set; }

        private readonly IEquipmentBrandAppService _service;

        public CreateModalModel(IEquipmentBrandAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(EquipmentBrand);
            return NoContent();
        }
    }
}