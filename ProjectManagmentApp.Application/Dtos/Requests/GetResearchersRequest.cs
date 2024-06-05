namespace ProjectManagmentApp.Application.Dtos.Requests
{
    public class GetResearchersRequest
    {
        public int? ResearcherRoleId { get; set; }
        public string? SearchTerm { get; set; }
    }
}
