namespace ProjectManagmentApp.Application.Dtos
{
    public class ResearcherDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public int? PhoneNumber { get; set; }
        public int ResearcherRoleId { get; set; }
        public string? ResearcherRoleName { get; set; }

    }
}
