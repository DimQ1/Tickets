using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tickets.Web.Models;

namespace Tickets.Web.Services
{
    public class TicketHttpClient : ApiClientBase<TicketDto>
    {
        public TicketHttpClient(IHttpClientFactory factory)
        {
            HttpClient = factory.CreateClient();
        }

        protected internal override Uri GetEndpoint<Tquery>(Tquery query, Uri BaseAddress)
        {
            UriBuilder returneUri =new UriBuilder(BaseAddress.AbsoluteUri);

            switch (query)
            {
                case int id:
                    returneUri.Query = $"/{id}";
                    break;
                default:

            }

            
        }

        protected internal override Task<ApiResponse<TicketDto, ErrorResponse>> ProcessingResponse<Tquery>(HttpResponseMessage httpResponseMessage, Tquery query)
        {
            throw new NotImplementedException();
        }
    }
}
