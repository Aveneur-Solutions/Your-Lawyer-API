using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Models.Messages;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.QueryFiles
{
    public class UploadToLegalx
    {
        public class Command : IRequest<QueryFileDTO>
        {
            public IFormFile File { get; set; }
        }

        public class Handler : IRequestHandler<Command, QueryFileDTO>
        {
            private readonly YourLawyerContext _context;
            private readonly IMapper _mapper;
            private readonly IWebHostEnvironment _environment;
            private readonly IUserAccessor _userAccessor;
            public Handler(YourLawyerContext context, IMapper mapper, IUserAccessor userAccessor, IWebHostEnvironment environment)
            {
                _userAccessor = userAccessor;
                _environment = environment;
                _mapper = mapper;
                _context = context;
            }
            public async Task<QueryFileDTO> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == _userAccessor.GetCurrentUsername());

                if (user == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, new { User = "Not found" });
                }

                var legalx = await _context.Users.FirstOrDefaultAsync(x => x.UserName == "legalx");

                string filePath = UploadFile(request.File);

                var message = new QueryFile
                {
                    Time = DateTime.Now,
                    Sender = user,
                    Receiver = legalx,
                    FilePath = filePath
                };

                //   user.SentQueryTexts.Add(message);
                await _context.QueryFile.AddAsync(message);
                var success = await _context.SaveChangesAsync() > 0;

                if (success) return _mapper.Map<QueryFile, QueryFileDTO>(message);

                throw new Exception("Problem saving changes");
            }

            private string UploadFile(IFormFile file)
            {
                string fileName = "amarfile";
                if (file != null)
                {
                    string path = Path.Combine(_environment.WebRootPath, "messaging-app", "public", "files");
                    fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string fileErPath = Path.Combine(path, fileName);
                    using (var fileStream = new FileStream(fileErPath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }
                return fileName;
            }
        }
    }
}