using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentSparePart
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateUpdateEquipmentSparePartDto EquipmentSparePart { get; set; }

        private readonly IEquipmentSparePartAppService _service;

        public CreateModalModel(IEquipmentSparePartAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(EquipmentSparePart);
            return NoContent();
        }
    }
}