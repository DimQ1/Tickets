using TrainTickets.Api.Data.Common;

namespace TrainTickets.Api.Data.Models
{
    public class Station : IEntity
    {
        public int Id { get; set; }
        public  string Name { get; set; }
    }

}