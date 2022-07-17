using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simulation.Tapes.ApplicationCore.Entities;
using Simulation.Tapes.ApplicationCore.Interfaces.Service;

namespace Simulation.Tapes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TapeController : ControllerBase
    {
        private readonly ITapeService _tapeService;
       public TapeController(ITapeService tapeService) 
       {
            _tapeService = tapeService;
       }

        [HttpGet]
        public async Task<IActionResult> getAllTapes()
        {
            try
            {
                var result = await _tapeService.GetAll();
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                string responseMessage = ex.Message;
                return new NotFoundObjectResult(responseMessage);
            }
        }

        [HttpPost]
        public async Task<IActionResult> insertTape(Tape tape)
        {
            try
            {
                await _tapeService.InsertTape(tape);
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
