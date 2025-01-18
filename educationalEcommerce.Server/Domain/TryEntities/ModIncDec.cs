namespace educationalEcommerce.Server.Domain.TryEntities
{
    public class ModIncDec
    {
        public Guid Id { get; set; }
        public Guid MainModId { get; set; }
        public MainMod MainMod { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<ModIncDecItem> ModIncDecItems { get; set; }
    }
}
