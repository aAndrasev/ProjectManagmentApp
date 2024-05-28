using ProjectManagmentApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
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
