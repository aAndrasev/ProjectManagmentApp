using System.ComponentModel.DataAnnotations;

namespace ProjectManagmentApp.Domain.Entities
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public Phase Phase { get; set; } 
        public int PhaseId { get; set; }


    }

}
