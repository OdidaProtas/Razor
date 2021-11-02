namespace UserApi.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsVerified { get; set; }
    }
}