using System.ComponentModel.DataAnnotations;

namespace ProjectManagmentApp.Domain.Entities
{
    public class ProjectStatus
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(20)]
        public string Name { get; set; }
    }
}
