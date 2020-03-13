using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;
using TrainTickets.Api.Data.Common;

namespace TrainTickets.Api.Data.Models
{
    public class User: IEntity
    {
        public int Id { get; set; }
        public  string UserName { get; set; }
        public string Email { get; set; }
    }
}
