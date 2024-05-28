using ProjectManagmentApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IPhaseService
    {
        Task<List<PhaseDTO>> GetPhasesAsync();
        Task<PhaseDTO> GetPhaseAsync(int id);
        Task<PhaseDTO> CreatePhaseAsync(PhaseDTO phaseDTO);
        Task<PhaseDTO> UpdatePhaseAsync(int id, PhaseDTO phaseDTO);
        Task<PhaseDTO> DeletePhaseAsync(int id);
    }
}
