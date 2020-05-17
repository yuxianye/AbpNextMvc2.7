using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentInspectionResult
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateUpdateEquipmentInspectionResultDto EquipmentInspectionResult { get; set; }

        private readonly IEquipmentInspectionResultAppService _service;

        public CreateModalModel(IEquipmentInspectionResultAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(EquipmentInspectionResult);
            return NoContent();
        }
    }
}