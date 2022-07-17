using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simulation.Tapes.ApplicationCore.Entities;
using Simulation.Tapes.ApplicationCore.Interfaces.Service;


namespace Simulation.Tapes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }

        [HttpGet]
        public async Task<IActionResult> getAllSections()
        {
            try
            {
                var result = await _sectionService.GetAll();
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                string responseMessage = ex.Message;
                return new NotFoundObjectResult(responseMessage);
            }
        }

        [HttpPost]
        public async Task<IActionResult> insertSection(Section section)
        {
            try
            {
                await _sectionService.InsertSection(section);
                string responseMessage = "object insert into database";
                return new OkObjectResult(responseMessage);
            }
            catch (Exception ex)
            {
                string responseMessage = ex.Message;
                return new BadRequestObjectResult(responseMessage);
            }

        }
    }
}
