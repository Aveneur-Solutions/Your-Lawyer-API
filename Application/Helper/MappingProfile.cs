using AutoMapper;
using Domain.DTOs;
using Domain.Models;
using Domain.Models.Messages;

namespace Application.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lawyer, LawyerDTO>().ForMember(x => x.DivisionName, o => o.MapFrom(s => s.Division.Name))
            .ForMember(x => x.Degrees, o => o.MapFrom(s => s.LawyerEducationalBGs))
            .ForMember(x => x.LawyersAreaOfLaws, o => o.MapFrom(s => s.LawyersAreaOfLaws));
            CreateMap<LawyerEducationalBG, LawyerEducationalBGDTO>();
            CreateMap<LawyerAndAreaOfLaw, AreaOfLawDTO>().ForMember(x => x.Name, o => o.MapFrom(s => s.AreaOfLaw.AreaOfLawName));
            // CreateMap<UserActivity,AttendeeDto>()
            // .ForMember(d => d.Username, o => o.MapFrom( s => s.AppUser.UserName))
            // .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.AppUser.DisplayName));
            CreateMap<QueryText, QueryTextDTO>().ForMember(x => x.SenderName, o => o.MapFrom(s => s.Sender.FirstName))
            .ForMember(x => x.ReceiverName, o => o.MapFrom(s => s.Receiver.FirstName));
            CreateMap<QueryFile, QueryFileDTO>().ForMember(x => x.SenderName, o => o.MapFrom(s => s.Sender.FirstName))
            .ForMember(x => x.ReceiverName, o => o.MapFrom(s => s.Receiver.FirstName));
        }
    }
}