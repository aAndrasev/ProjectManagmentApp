using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Dtos.Requests;
using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces
{
    public interface IProjectService
    {
        Task<List<ProjectDTO>> GetProjectsAsync(GetProjectsRequest request);
        Task<ProjectDTO> GetProjectAsync(int id);
        Task<ProjectDTO> CreateProjectAsync(ProjectDTO projectDTO);
        Task<ProjectDTO> UpdateProjectAsync(int id, ProjectDTO projectDTO);
        Task DeleteProjectAsync(int id);
    }
}
