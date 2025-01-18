namespace educationalEcommerce.Server.Domain.TryEntities
{
    public class ModIncDecItem
    {
        public Guid Id { get; set; }
        public Guid ModIncDecId { get; set; }
        public ModIncDec ModIncDec { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Price { get; set; }

    }
}
