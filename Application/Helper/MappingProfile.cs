using AutoMapper;
using Domain.DTOs;
using Domain.Models;

namespace Application.Helper
{
    public class MappingProfile : Profile
    {
           public MappingProfile()
        {
            CreateMap<Lawyer,LawyerDTO>().ForMember(x => x.DivisionName, o => o.MapFrom( s => s.Division.Name))
            .ForMember(x => x.Degrees,o=> o.MapFrom(s => s.LawyerEducationalBGs))
            .ForMember(x => x.LawyersAreaOfLaws , o=> o.MapFrom(s=> s.LawyersAreaOfLaws));
            CreateMap<LawyerEducationalBG,LawyerEducationalBGDTO>();
            CreateMap<LawyerAndAreaOfLaw,AreaOfLawDTO>().ForMember(x => x.Name,o=> o.MapFrom(s=>s.AreaOfLaw.AreaOfLawName));        
            // CreateMap<UserActivity,AttendeeDto>()
            // .ForMember(d => d.Username, o => o.MapFrom( s => s.AppUser.UserName))
            // .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.AppUser.DisplayName));
        }
    }
}