using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentStatus
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateEquipmentStatusDto EquipmentStatus { get; set; }

        private readonly IEquipmentStatusAppService _service;

        public EditModalModel(IEquipmentStatusAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            EquipmentStatus = ObjectMapper.Map<EquipmentStatusDto, CreateUpdateEquipmentStatusDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, EquipmentStatus);
            return NoContent();
        }
    }
}