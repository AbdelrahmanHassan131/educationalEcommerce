using AutoMapper;
using educationalEcommerce.Server.Domain.TryEntities;
using educationalEcommerce.Server.Profiles.Dto.TryDto;

namespace educationalEcommerce.Server.Profiles
{
    public class MainModProfile : Profile
    {
        public MainModProfile()
        {
            CreateMap<MainMod, MainModDto>()
            //     .ForMember(dest => dest.MainItems,

            //     opt => opt.MapFrom((src, dest, c, context) =>
            //     {
            //         var mainItemsIncDec = context.Mapper.Map<IQueryable<MainItemDto>>(
            //                 src.ModIncDecs.SelectMany(modIncDec => modIncDec.ModIncDecItems).AsQueryable()
            //             );

            //         var mainItemsAlt = context.Mapper.Map<IQueryable<MainItemDto>>(
            //                 src.ModAlts.SelectMany(modAlt => modAlt.ModAltItems).AsQueryable()
            //             );

            //         return mainItemsAlt.Concat(mainItemsIncDec).AsQueryable();
            //     })

            //// opt => opt.MapFrom(src => src.ModAlts.SelectMany(modIncDec => modIncDec.ModAltItems).AsQueryable())



            // );
            .ForMember(dest => dest.MainItems,
                opt => opt.MapFrom(src =>
                    src.ModIncDecs
                        .SelectMany(modIncDec => modIncDec.ModIncDecItems)
                        .Select(item => new MainItemDto
                        {
                            
                            Id = item.Id,
                            Name = item.Name,
                            LastName = item.LastName,
                            ModName = item.ModIncDec.Name
                        })
                    .Concat(
                        src.ModAlts
                            .SelectMany(modAlt => modAlt.ModAltItems)
                            .Select(item => new MainItemDto
                            {
                                Id = item.Id,
                                Name = item.Name,
                                LastName = item.LastName,
                                ModName = item.ModAlt.Name
                            })
                    )
                )
            );
        }
        
    }
}
