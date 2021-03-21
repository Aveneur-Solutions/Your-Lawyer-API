using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using AutoMapper;
using Domain.DTOs;
using Domain.Models.Messages;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.QueryTexts
{
    public class SendTextToUser
    {
        public class Command : IRequest<QueryTextDTO>
        {
            public string Body { get; set; }
            public string PhoneNumber { get; set; }
        }

        public class Handler : IRequestHandler<Command, QueryTextDTO>
        {
            private readonly YourLawyerContext _context;
            private readonly IMapper _mapper;
            public Handler(YourLawyerContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }
            public async Task<QueryTextDTO> Handle(Command request, CancellationToken cancellationToken)
            {
                var legalx = await _context.Users.FirstOrDefaultAsync(x => x.UserName == "legalx");

                if (legalx == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, new { User = "Not found" });
                }

                var user = await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber);

                var message = new QueryText
                {
                    Time = DateTime.Now,
                    Sender = legalx,
                    Receiver = user,
                    Text = request.Body
                };

                //  user.SentQueryTexts.Add(message);
                await _context.QueryText.AddAsync(message);
                var success = await _context.SaveChangesAsync() > 0;

                if (success) return _mapper.Map<QueryText, QueryTextDTO>(message);

                throw new Exception("Problem saving changes");
            }
        }
    }
}