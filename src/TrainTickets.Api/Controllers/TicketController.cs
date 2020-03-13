using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainTickets.Api.Services;
using TrainTickets.Api.Services.Models;

namespace TrainTickets.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketsService _ticketsService;

        public TicketController(TicketsService ticketsService)
        {
            _ticketsService = ticketsService;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {

           var tickets = _ticketsService.GeTickets();

            return new JsonResult(tickets);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetById(int id)
        {

            var tickets = _ticketsService.GetById(id);

            return new JsonResult(tickets);
        }

        [HttpGet("Find")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult FindByParameters([FromQuery] SearchParameters parameters)
        {
            var tickets = _ticketsService.SearchByParameters(parameters);

            return new JsonResult(tickets);
        }

    }
}