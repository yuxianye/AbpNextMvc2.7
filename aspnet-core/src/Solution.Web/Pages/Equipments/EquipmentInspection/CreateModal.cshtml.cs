using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentInspection
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateUpdateEquipmentInspectionDto EquipmentInspection { get; set; }

        private readonly IEquipmentInspectionAppService _service;

        public CreateModalModel(IEquipmentInspectionAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(EquipmentInspection);
            return NoContent();
        }
    }
}