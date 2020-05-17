using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentSparePartType
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateEquipmentSparePartTypeDto EquipmentSparePartType { get; set; }

        private readonly IEquipmentSparePartTypeAppService _service;

        public EditModalModel(IEquipmentSparePartTypeAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            EquipmentSparePartType = ObjectMapper.Map<EquipmentSparePartTypeDto, CreateUpdateEquipmentSparePartTypeDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, EquipmentSparePartType);
            return NoContent();
        }
    }
}