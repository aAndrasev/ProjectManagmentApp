using System.ComponentModel.DataAnnotations;

namespace ProjectManagmentApp.Domain.Entities
{
    public class Researcher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public int? PhoneNumber { get; set; }
        public int ResearcherRoleId { get; set; }
        public ResearcherRole ResearcherRole { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
