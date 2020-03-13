using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrainTickets.Api.Services.Models
{
    public class SearchParameters
    {
        [FromQuery]
        public string StationFrom { get; set; }
        [FromQuery]
        public string StationTo { get; set; }
        [FromQuery]
        public DateTime DepartureDate { get; set; }
        [FromQuery]
        public DateTime ArrivalDate { get; set; }
    }
}
