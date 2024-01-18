using AutoMapper;
using SmsServiceProject.Domain.Models;
using SmsServiceProject.Dtos;

namespace SmsServiceProject.Helpers.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SmsMessage, InternalSmsRequestDto>().ReverseMap();

            CreateMap<SmsRequestDto, InternalSmsRequestDto>().ReverseMap();
        }
    }
}