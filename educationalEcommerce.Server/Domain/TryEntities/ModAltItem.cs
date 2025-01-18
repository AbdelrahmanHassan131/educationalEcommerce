namespace educationalEcommerce.Server.Domain.TryEntities
{
    public class ModAltItem
    {
        public Guid Id { get; set; }
        public Guid ModAltId { get; set; }
        public ModAlt ModAlt { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Price { get; set; }
    }
}
