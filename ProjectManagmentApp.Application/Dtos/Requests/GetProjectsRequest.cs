namespace ProjectManagmentApp.Application.Dtos.Requests
{
    public class GetProjectsRequest    
    {
        public int? ProjectStatusId { get; set; }
        public string? SearchTerm { get; set; }
    }
}
