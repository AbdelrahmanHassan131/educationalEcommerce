namespace educationalEcommerce.Server.Domain.TryEntities
{
    public class MainMod
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModIncDec> ModIncDecs{ get; set; }
        public ICollection<ModAlt> ModAlts { get; set; }
    }
}
