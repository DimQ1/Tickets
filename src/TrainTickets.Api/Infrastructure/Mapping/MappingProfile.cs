using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TrainTickets.Api.Data.Models;
using TrainTickets.Api.Services.Models;


namespace TrainTickets.Api.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TicketDto, Ticket>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<TrainDto, Train>().ReverseMap();
            CreateMap<StationDto, Station>().ReverseMap();
        }
    }
}
