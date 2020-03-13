using System;

namespace TrainTickets.Api.Services.Models
{
    public class TicketDto
    {
        public int Id { get; set; }
        public TrainDto Train { get; set; }
        public int CarNumber { get; set; }
        public StationDto StationFrom { get; set; }
        public StationDto StationTo { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}