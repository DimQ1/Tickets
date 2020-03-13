using TrainTickets.Api.Data.Common;

namespace TrainTickets.Api.Data.Models
{
    public class Train : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}