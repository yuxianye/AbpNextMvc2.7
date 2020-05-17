using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentMaintenanceResult
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateEquipmentMaintenanceResultDto EquipmentMaintenanceResult { get; set; }

        private readonly IEquipmentMaintenanceResultAppService _service;

        public EditModalModel(IEquipmentMaintenanceResultAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            EquipmentMaintenanceResult = ObjectMapper.Map<EquipmentMaintenanceResultDto, CreateUpdateEquipmentMaintenanceResultDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, EquipmentMaintenanceResult);
            return NoContent();
        }
    }
}