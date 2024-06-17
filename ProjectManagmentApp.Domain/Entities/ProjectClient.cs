namespace ProjectManagmentApp.Domain.Entities
{
    public class ProjectClient
    {
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmail { get; set; }
        public int? ContactPhoneNumber { get; set; }
    }
}
