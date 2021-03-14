using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Application.QueryMessages;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace API.SignalR
{
    public class QueryHub : Hub
    {
        private readonly IMediator _mediator;
        public QueryHub(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendQueryTextToLegalx(string body)
        {
            var username = Context.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            // command.UserName = username;

            var message = await _mediator.Send(new Send.Command { Body = body, UserName = username });

            await Clients.All.SendAsync("ReceiveQueryTexts", message);
        }
    }
}