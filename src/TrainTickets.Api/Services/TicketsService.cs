using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TrainTickets.Api.Controllers;
using TrainTickets.Api.Data.Models;
using TrainTickets.Api.Data.Services;
using TrainTickets.Api.Services.Models;

namespace TrainTickets.Api.Services
{
    public class TicketsService
    {
        private readonly Tikets _ticketsService;
        private readonly IMapper _mapper;

        public TicketsService(Tikets ticketsService, IMapper mapper)
        {
            _ticketsService = ticketsService;
            _mapper = mapper;
        }

        public IEnumerable<TicketDto> GeTickets()
        {
            var tickets = _ticketsService.GetWithInclude(t=>t.StationFrom, ticket => ticket.StationTo, ticket =>ticket.Train  );
            var result = _mapper.Map<IEnumerable<TicketDto>>(tickets);
            return result;
        }

        public void Add(TicketDto ticket)
        {
            var newTicket = _mapper.Map<Ticket>(ticket);
            _ticketsService.Create(newTicket);
        }

        public TicketDto GetById(int id)
        {
            var ticket = _ticketsService.FindById(id);
            return _mapper.Map<TicketDto>(ticket);
        }

        public IEnumerable<TicketDto> SearchByParameters(SearchParameters parameters)
        {
            var tickets = _ticketsService.GetWithInclude(t => (
                (parameters.StationFrom == null || t.StationFrom?.Name == parameters.StationFrom)
                &&
                (parameters.StationTo == null || t.StationTo?.Name == parameters.StationTo)
                &&
                (parameters.ArrivalDate == DateTime.MinValue || t.ArrivalDate.Date == parameters.ArrivalDate.Date)
                &&
                (parameters.DepartureDate == DateTime.MinValue || t.DepartureDate.Date == parameters.DepartureDate.Date)
            ), t => t.StationFrom, ticket => ticket.StationTo, ticket => ticket.Train);

            var result = _mapper.Map<IEnumerable<TicketDto>>(tickets);
            return result;
        }
    }
}
