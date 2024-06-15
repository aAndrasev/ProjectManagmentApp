namespace ProjectManagmentApp.Domain.Entities
{
    public class ProjectResearcher
    {
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public Researcher Researcher { get; set; }
        public int ResearcherId { get; set; }
        public ResearcherRole ResearcherRoles { get; set; }
        public int ResearcherRoleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }


    }
}
