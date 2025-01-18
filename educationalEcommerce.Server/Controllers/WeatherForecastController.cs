using AutoMapper;
using AutoMapper.QueryableExtensions;
using educationalEcommerce.Server.Domain.TryEntities;
using educationalEcommerce.Server.Infrastructure;
using educationalEcommerce.Server.Profiles;
using educationalEcommerce.Server.Profiles.Dto.TryDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace educationalEcommerce.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IMapper _mapper;
        private EduCommDbContext _dbContext;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper, EduCommDbContext dbContext)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            //var emptyTempObject = new TempClass
            //{
            //    Id = Guid.NewGuid(),
            //    ListObject1 = new List<Object1>
            //    {
            //        new Object1
            //        {
            //            Id = Guid.NewGuid(),
            //            Name = "Name 1 object 1",
            //            Number = 1,
            //            ListOfSubObject1 = new List<SubObject1>
            //            {
            //                new SubObject1
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 2",
            //                    Number = 1,
            //                },
            //                new SubObject1
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 3",
            //                    Number = 2,
            //                },
            //                new SubObject1
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 4",
            //                    Number = 3,
            //                }
            //            }

            //        },

            //        new Object1
            //        {
            //            Id = Guid.NewGuid(),
            //            Name = "Name 1 object 2",
            //            Number = 1,
            //            ListOfSubObject1 = new List<SubObject1>
            //            {
            //                new SubObject1
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 2",
            //                    Number = 1,
            //                },
            //                new SubObject1
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 3",
            //                    Number = 2,
            //                },
            //                new SubObject1
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 4",
            //                    Number = 3,
            //                }
            //            }

            //        },

            //    },
            //    ListObject2 = new List<Object2>
            //    {
            //        new Object2
            //        {
            //            Id = Guid.NewGuid(),
            //            Name = "Name 1 object 1",
            //            Number = 1,
            //            ListOfSubObject2 = new List<SubObject2>
            //            {
            //                new SubObject2
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 2",
            //                    Number = 1,
            //                },
            //                new SubObject2
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 3",
            //                    Number = 2,
            //                },
            //                new SubObject2
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 4",
            //                    Number = 3,
            //                }
            //            }

            //        },

            //        new Object2
            //        {
            //            Id = Guid.NewGuid(),
            //            Name = "Name 1 object 2",
            //            Number = 1,
            //            ListOfSubObject2 = new List<SubObject2>
            //            {
            //                new SubObject2
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 2",
            //                    Number = 1,
            //                },
            //                new SubObject2
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 3",
            //                    Number = 2,
            //                },
            //                new SubObject2
            //                {
            //                    Id = Guid.NewGuid(),
            //                    Name = "sub object 4",
            //                    Number = 3,
            //                }
            //            }

            //        },

            //    }
            //};
            //var values = _dbContext.Carts.ToList();

            //var mappedValue = _mapper.Map<TempClassDto>(emptyTempObject);

            //var secondTryMainMod = new MainMod
            //{
            //    Id = Guid.Empty,
            //    Name = "second Main Mod",
            //    ModAlts = new List<ModAlt> 
            //    {
            //        new ModAlt 
            //        {
            //            Id = Guid.Empty,
            //            Name = "First Mod Alt",
            //            LastName = "Last Name",
            //            MainModId = Guid.Empty,
            //            ModAltItems = new List<ModAltItem> 
            //            {
            //                new ModAltItem 
            //                {
            //                    Id = Guid.Empty,
            //                    Name = "First Mod Alt Item",
            //                    LastName = "Last Name",
            //                    Price = 12,
            //                    ModAltId = Guid.Empty,
            //                },
            //                new ModAltItem
            //                {
            //                    Id = Guid.Empty,
            //                    Name = "Second Mod Alt Item",
            //                    LastName = "Last Name",
            //                    Price = 121,
            //                    ModAltId = Guid.Empty,
            //                }
            //            }
            //        },
            //        new ModAlt
            //        {
            //            Id = Guid.Empty,
            //            Name = "Second Mod Alt",
            //            LastName = "Last Name",
            //            MainModId = Guid.Empty,
            //            ModAltItems = new List<ModAltItem>
            //            {
            //                new ModAltItem
            //                {
            //                    Id = Guid.Empty,
            //                    Name = "First Mod Alt Item",
            //                    LastName = "Last Name",
            //                    Price = 122,
            //                    ModAltId = Guid.Empty,
            //                }
            //            }
            //        }
            //    },
            //    ModIncDecs = new List<ModIncDec>
            //    {
            //        new ModIncDec 
            //        {
            //            Id = Guid.Empty,
            //            Name = "First Inc Dec",
            //            LastName = "Last Name",
            //            MainModId = Guid.Empty,
            //            ModIncDecItems = new List<ModIncDecItem> 
            //            {
            //                new ModIncDecItem
            //                {
            //                    Id = Guid.Empty,
            //                    Name = "First Inc Dec Item",
            //                    LastName = "Last Name",
            //                    ModIncDecId = Guid.Empty,
            //                    Price = 1
            //                },
            //                new ModIncDecItem
            //                {
            //                    Id = Guid.Empty,
            //                    Name = "Second Inc Dec Item",
            //                    LastName = "Last Name",
            //                    ModIncDecId = Guid.Empty,
            //                    Price = 145
            //                }
            //            }
            //        },
            //        new ModIncDec
            //        {
            //            Id = Guid.Empty,
            //            Name = "Second Inc Dec",
            //            LastName = "Last Name",
            //            MainModId = Guid.Empty,
            //            ModIncDecItems = new List<ModIncDecItem>
            //            {
            //                new ModIncDecItem
            //                {
            //                    Id = Guid.Empty,
            //                    Name = "First Inc Dec Item",
            //                    LastName = "Last Name",
            //                    ModIncDecId = Guid.Empty,
            //                    Price = 1
            //                }
            //            }
            //        }
            //    }

            //};

            //_dbContext.MainMods.Add(secondTryMainMod);

            //await _dbContext.SaveChangesAsync();


            var data = _dbContext.MainMods
                .ProjectTo<MainModDto>(_mapper.ConfigurationProvider);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
