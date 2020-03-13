using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainTickets.Api.Services;
using TrainTickets.Api.Services.Models;

namespace TrainTickets.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageTicketController : ControllerBase
    {
        private readonly TicketsService _ticketsService;

        public ManageTicketController(TicketsService ticketsService)
        {
            _ticketsService = ticketsService;
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Add([FromBody] TicketDto ticket)
        {

           _ticketsService.Add(ticket);

            return new JsonResult("Ok");
        }
    }
}