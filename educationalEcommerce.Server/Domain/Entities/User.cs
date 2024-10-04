namespace educationalEcommerce.Server.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Cart Cart { get; set; }
    }
}
