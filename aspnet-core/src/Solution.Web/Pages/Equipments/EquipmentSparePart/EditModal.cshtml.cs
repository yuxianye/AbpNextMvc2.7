using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentSparePart
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateEquipmentSparePartDto EquipmentSparePart { get; set; }

        private readonly IEquipmentSparePartAppService _service;

        public EditModalModel(IEquipmentSparePartAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            EquipmentSparePart = ObjectMapper.Map<EquipmentSparePartDto, CreateUpdateEquipmentSparePartDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, EquipmentSparePart);
            return NoContent();
        }
    }
}