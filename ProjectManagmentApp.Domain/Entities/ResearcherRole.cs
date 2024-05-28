using System.ComponentModel.DataAnnotations;

namespace ProjectManagmentApp.Domain.Entities
{
    public class ResearcherRole
    {
        [Key]
        public int Id { get; set; }
        public  string Name { get; set; }
    }
}
