namespace Core.Services.Services
{
    public class IRequestContext
    {
        public User User { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}