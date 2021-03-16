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

            var id = username + "abcdef";

            var message = await _mediator.Send(new SendToLegalx.Command { Body = body, UserName = username });

            await Clients.Group(id).SendAsync("ReceiveQueryTexts", message);
        }

        public async Task SendQueryTextToUser(string body, string userName)
        {
            var id = userName + "abcdef";

            var message = await _mediator.Send(new SendToUser.Command { Body = body, UserName = userName });

            await Clients.Group(id).SendAsync("ReceiveQueryTexts", message);
        }

        public async Task ConnectToLegalx(string id)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, id);
        }

        public async Task ConnectToUser(string id)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, id);
        }
    }
}