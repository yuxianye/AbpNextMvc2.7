using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentMaintenanceResult
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateUpdateEquipmentMaintenanceResultDto EquipmentMaintenanceResult { get; set; }

        private readonly IEquipmentMaintenanceResultAppService _service;

        public CreateModalModel(IEquipmentMaintenanceResultAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(EquipmentMaintenanceResult);
            return NoContent();
        }
    }
}