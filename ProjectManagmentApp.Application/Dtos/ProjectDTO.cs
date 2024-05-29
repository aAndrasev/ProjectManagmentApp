using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Dtos
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime DateOfCreation { get; set; }

        public DateTime PlannedStartDate { get; set; }

        public DateTime PlannedEndDate { get; set; }
    }
}
