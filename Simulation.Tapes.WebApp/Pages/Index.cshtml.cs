using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Simulation.Tapes.ApplicationCore.Entities;
using Simulation.Tapes.ApplicationCore.Interfaces.Service;

namespace Simulation.Tapes.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ISectionService _sectionService;

        [BindProperty]
        public IEnumerable<Section> sections { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ISectionService sectionService)
        {
            _logger = logger;
            _sectionService = sectionService;

        }

        public async Task OnGetAsync()
        {
            sections = await _sectionService.GetAll();
        }
    }
}