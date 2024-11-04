namespace DataAccess
{
    public class Member
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string CompanyName { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string Password { get; set; }
        public ICollection<Order>? orders { get; set; }
    }
}
