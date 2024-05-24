using ProjectManagmentApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces
{
    public interface IProjectService
    {
        Task<List<ProjectDTO>> GetProjectsAsync();
        Task<ProjectDTO> GetProjectAsync(int id);
    }
}
