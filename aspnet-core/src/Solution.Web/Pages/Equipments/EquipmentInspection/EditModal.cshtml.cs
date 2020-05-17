using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentInspection
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateEquipmentInspectionDto EquipmentInspection { get; set; }

        private readonly IEquipmentInspectionAppService _service;

        public EditModalModel(IEquipmentInspectionAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            EquipmentInspection = ObjectMapper.Map<EquipmentInspectionDto, CreateUpdateEquipmentInspectionDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, EquipmentInspection);
            return NoContent();
        }
    }
}