namespace ProjectManagmentApp.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Email { get; set; }
        public int? PhoneNumber { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
