using AutoMapper;
using blinkCat.Models;
using blinkCore.Entities;

namespace blinkCat.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserViewModel, User>().ReverseMap();
        }
    }
}
