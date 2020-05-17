using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentInspectionResult
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateEquipmentInspectionResultDto EquipmentInspectionResult { get; set; }

        private readonly IEquipmentInspectionResultAppService _service;

        public EditModalModel(IEquipmentInspectionResultAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            EquipmentInspectionResult = ObjectMapper.Map<EquipmentInspectionResultDto, CreateUpdateEquipmentInspectionResultDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, EquipmentInspectionResult);
            return NoContent();
        }
    }
}