namespace Tickets.Web.Models
{
    public class TicketDto
    {
        public int Id { get; set; }

        public TrainDto Train { get; set; }

        public int CarNumber { get; set; }

        public StationDto StationFrom { get; set; }

        public StationDto StationTo { get; set; }

        public System.DateTimeOffset DepartureDate { get; set; }

        public System.DateTimeOffset ArrivalDate { get; set; }

        public System.DateTimeOffset CreatedDate { get; set; }

        public System.DateTimeOffset LastUpdateDate { get; set; }
    }


}
