using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Tickets.Web.Models;

namespace Tickets.Web.Services
{
    public abstract class ApiClientBase<T> where T : class
    {
        protected internal HttpClient HttpClient { get; set; }
        protected internal ILogger Logger { get; set; }

        public async Task<ApiResponse<T, ErrorResponse>> GetDataBy<Tquery>(Tquery query, CancellationToken cancellationToken)
        {
            var endPoint = GetEndpoint(query, HttpClient.BaseAddress);

            var stopWatch = Stopwatch.StartNew();

            using (var httpResponseMessage = await HttpClient.GetAsync(endPoint, cancellationToken).ConfigureAwait(false))
            {
                httpResponseMessage.EnsureSuccessStatusCode();
                var response = await ProcessingResponse(httpResponseMessage, query).ConfigureAwait(false);
                return response;
            }
        }

        protected internal abstract Task<ApiResponse<T, ErrorResponse>> ProcessingResponse<Tquery>(HttpResponseMessage httpResponseMessage, Tquery query);

        protected internal abstract Uri GetEndpoint<Tquery>(Tquery query, Uri BaseAddress);
    }
}
