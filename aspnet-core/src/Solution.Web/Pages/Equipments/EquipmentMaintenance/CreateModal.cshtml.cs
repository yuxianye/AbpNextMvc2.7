using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentMaintenance
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateUpdateEquipmentMaintenanceDto EquipmentMaintenance { get; set; }

        private readonly IEquipmentMaintenanceAppService _service;

        public CreateModalModel(IEquipmentMaintenanceAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(EquipmentMaintenance);
            return NoContent();
        }
    }
}