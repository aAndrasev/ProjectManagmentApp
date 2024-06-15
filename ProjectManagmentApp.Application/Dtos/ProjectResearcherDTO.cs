using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Dtos
{
    public class ProjectResearcherDTO
    {
        
        public int? ProjectId { get; set; }
        public int? ResearcherId { get; set; }
        public int? ResearcherRoleId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
