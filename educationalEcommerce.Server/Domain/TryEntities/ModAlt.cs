namespace educationalEcommerce.Server.Domain.TryEntities
{
    public class ModAlt
    {
        public Guid Id { get; set; }
        public Guid MainModId { get; set; }
        public MainMod MainMod { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<ModAltItem> ModAltItems{ get; set; }
    }
}
