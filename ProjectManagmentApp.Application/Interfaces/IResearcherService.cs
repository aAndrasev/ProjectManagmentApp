using ProjectManagmentApp.Application.Dtos;

namespace ProjectManagmentApp.Application.Interfaces
{
    public interface IResearcherService
    {
        Task<List<ResearcherDTO>> GetResearchersAsync();
        Task<ResearcherDTO> GetResearcherAsync(int id);
        Task<ResearcherDTO> CreateResearcherAsync(ResearcherDTO researcherDTO);
        Task<ResearcherDTO> UpdateResearcherAsync(int id, ResearcherDTO researcherDTO);
        Task<ResearcherDTO> DeleteResearcherAsync(int id);
    }
}
