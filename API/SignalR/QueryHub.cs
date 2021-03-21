using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Application.QueryFiles;
using Application.QueryTexts;
using Domain.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
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
            var phoneNumber = Context.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            var id = phoneNumber + "legalx";

            var message = await _mediator.Send(new SendTextToLegalx.Command { Body = body, PhoneNumber = phoneNumber });

            await Clients.Group(id).SendAsync("ReceiveQueryTexts", message);
        }

        public async Task SendQueryFileToLegalx(QueryFileDTO file)
        {
            var phoneNumber = Context.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            var id = phoneNumber + "legalx";

            await Clients.Group(id).SendAsync("ReceiveQueryFiles", file);
        }

        public async Task SendQueryTextToUser(string body, string phoneNumber)
        {
            var id = phoneNumber + "legalx";

            var message = await _mediator.Send(new SendTextToUser.Command { Body = body, PhoneNumber = phoneNumber });

            await Clients.Group(id).SendAsync("ReceiveQueryTexts", message);
        }

        public async Task SendQueryFileToUser(QueryFileDTO file, string phoneNumber)
        {
            var id = phoneNumber + "legalx";

            await Clients.Group(id).SendAsync("ReceiveQueryFiles", file);
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