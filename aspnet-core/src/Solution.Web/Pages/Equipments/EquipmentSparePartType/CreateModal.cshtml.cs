using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentSparePartType
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateUpdateEquipmentSparePartTypeDto EquipmentSparePartType { get; set; }

        private readonly IEquipmentSparePartTypeAppService _service;

        public CreateModalModel(IEquipmentSparePartTypeAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(EquipmentSparePartType);
            return NoContent();
        }
    }
}