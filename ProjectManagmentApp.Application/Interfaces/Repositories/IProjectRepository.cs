using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        IQueryable<Project> GetAllAsync();
        Task<Project?> GetByIdAsync(int id);
        Task<Project> CreateAsync(Project project);
        Task<Project> UpdateAsync(Project project); 
        Task DeleteAsync(int id);
    }
}
