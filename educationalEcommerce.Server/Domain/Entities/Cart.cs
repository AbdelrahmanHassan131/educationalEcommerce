namespace educationalEcommerce.Server.Domain.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<Item>? Items { get; set; } = null;

    }
}
