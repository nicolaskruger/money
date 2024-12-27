namespace Money.Models
{
    public class User
    {
        public User() => this.Id = Guid.NewGuid().ToString();

        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
