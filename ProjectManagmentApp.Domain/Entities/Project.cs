﻿using System.ComponentModel.DataAnnotations;

namespace ProjectManagmentApp.Domain.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime DateOfCreation { get; set; }

        public DateTime PlannedStartDate { get; set; }

        public DateTime PlannedEndDate { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public int ProjectStatusId { get; set; }
        public virtual ICollection<ProjectResearcher> ProjectResearchers { get; set; }
        public virtual ICollection<ProjectClient> ProjectClients { get; set; }
        public virtual ICollection<Phase> Phases { get; set; }


    }
}
