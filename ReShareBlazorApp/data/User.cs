namespace ReShareBlazorApp.data
{
    public class User
    {
        public int id { get; set; }
        public required string username { get; set; }
        public required string email { get; set; }
        public required string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
