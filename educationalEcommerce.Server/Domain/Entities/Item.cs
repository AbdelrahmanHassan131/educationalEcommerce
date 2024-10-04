namespace educationalEcommerce.Server.Domain.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CartId { get; set; }
        public Cart Cart { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
