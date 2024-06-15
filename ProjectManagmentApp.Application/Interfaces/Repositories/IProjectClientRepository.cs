using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IProjectClientRepository
    {
        IQueryable<ProjectClient> GetAllAsync();
        Task<ProjectClient> CreateAsync(ProjectClient projectClient);
        Task<ProjectClient> UpdateAsync(ProjectClient projectClient);
        Task DeleteAsync(int projectId, int clientId);
    }
}
