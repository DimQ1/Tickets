using TrainTickets.Api.Data.Common;
using TrainTickets.Api.Data.Models;

namespace TrainTickets.Api.Data.Services
{
    public class Tikets : BaseRepositiry<Ticket>
    {
        private readonly TrainTicketDbContext _context;

        public Tikets(TrainTicketDbContext context) : base(context)
        {
            _context = context;
        }
    }
}