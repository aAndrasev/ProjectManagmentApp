using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IResearcherRepository
    {
        IQueryable<Researcher> GetAllAsync();
        Task<Researcher?> GetByIdAsync(int id);
        Task<Researcher> CreateAsync(Researcher researcher);
        Task<Researcher> UpdateAsync(Researcher researcher);
        Task<Researcher> DeleteAsync(int id);
    }
}
