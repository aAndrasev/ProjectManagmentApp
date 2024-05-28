using System.ComponentModel.DataAnnotations;

namespace ProjectManagmentApp.Domain.Entities
{
    public class Phase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Description { get; set; }

        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }

}
