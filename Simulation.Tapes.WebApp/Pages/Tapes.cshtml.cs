using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Simulation.Tapes.ApplicationCore.Entities;
using Simulation.Tapes.ApplicationCore.Interfaces.Service;

namespace Simulation.Tapes.WebApp.Pages
{
    public class TapesModel : PageModel
    {
        private ITapeService _tapeService;

        public TapesModel(ITapeService tapeService)
        {
            _tapeService = tapeService;
        }

        [BindProperty]
        public IEnumerable<Tape> tapes { get; set; }
        public async Task OnGetAsync(int tapesId)
        {
            tapes = await _tapeService.GetAllById(tapesId);

        }
    }
}
