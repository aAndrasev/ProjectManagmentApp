namespace ProjectManagmentApp.Domain.Entities
{
    public class ProjectClient
    {
        public Project Projects { get; set; }
        public int ProjectId { get; set; }
        public Client Clients { get; set; }
        public int ClientId { get; set; }
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }
    }
}
