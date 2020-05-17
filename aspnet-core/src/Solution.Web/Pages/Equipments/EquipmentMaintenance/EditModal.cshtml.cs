using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentMaintenance
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateEquipmentMaintenanceDto EquipmentMaintenance { get; set; }

        private readonly IEquipmentMaintenanceAppService _service;

        public EditModalModel(IEquipmentMaintenanceAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            EquipmentMaintenance = ObjectMapper.Map<EquipmentMaintenanceDto, CreateUpdateEquipmentMaintenanceDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, EquipmentMaintenance);
            return NoContent();
        }
    }
}