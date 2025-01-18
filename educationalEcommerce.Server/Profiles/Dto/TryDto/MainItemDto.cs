using AutoMapper;
using educationalEcommerce.Server.Domain.TryEntities;

namespace educationalEcommerce.Server.Profiles.Dto.TryDto
{
    public class MainItemDto
    {
        public Guid Id { get; set; }
        public string ModName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Price { get; set; }

        private class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<ModIncDecItem, MainItemDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                    .ForMember(dest => dest.ModName, opt => opt.MapFrom(src => src.ModIncDec.Name + " " + src.ModIncDec.LastName));

                CreateMap<ModAltItem, MainItemDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                    .ForMember(dest => dest.ModName, opt => opt.MapFrom(src => src.ModAlt.Name + " " + src.ModAlt.LastName));
            }
        }
    }
}
