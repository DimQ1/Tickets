using System;
using TrainTickets.Api.Data.Common;

namespace TrainTickets.Api.Data.Models
{
    public class Ticket: IEntity
    {
        public int Id { get; set; }
        public Train Train { get; set; }
        public int CarNumber { get; set; }
        public Station StationFrom { get; set; }
        public Station StationTo { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}