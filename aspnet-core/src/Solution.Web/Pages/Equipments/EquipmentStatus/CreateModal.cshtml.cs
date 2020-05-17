using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;

namespace Solution.Web.Pages.Equipments.EquipmentStatus
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateUpdateEquipmentStatusDto EquipmentStatus { get; set; }

        private readonly IEquipmentStatusAppService _service;

        public CreateModalModel(IEquipmentStatusAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(EquipmentStatus);
            return NoContent();
        }
    }
}