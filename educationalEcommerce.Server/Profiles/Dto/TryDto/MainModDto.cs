using AutoMapper;
using educationalEcommerce.Server.Domain.TryEntities;

namespace educationalEcommerce.Server.Profiles.Dto.TryDto
{
    public class MainModDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<MainItemDto> MainItems { get; set; } = new List<MainItemDto>();
    }
}
