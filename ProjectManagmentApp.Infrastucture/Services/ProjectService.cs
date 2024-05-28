using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Infrastucture.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public ProjectService(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }

        //***** CRUD METHODS *****//
        public async Task<List<ProjectDTO>> GetProjectsAsync()
        {
            return await _projectRepository
                 .GetAllAsync()
                 .ProjectTo<ProjectDTO>(_mapper.ConfigurationProvider)
                 .ToListAsync();
        }

        public async Task<ProjectDTO> GetProjectAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);
            if (project == null)
            {
                return null;
            }

            return _mapper.Map<ProjectDTO>(project);
        }

        public async Task<ProjectDTO> CreateProjectAsync(ProjectDTO projectDTO)
        {
            var project = _mapper.Map<Project>(projectDTO);
            var createdProject = await _projectRepository.CreateAsync(project);
            return _mapper.Map<ProjectDTO>(createdProject);
        }

        public async Task<ProjectDTO> UpdateProjectAsync(int id, ProjectDTO projectDTO)
        {
            var existingProject = await _projectRepository.GetByIdAsync(id);
            if (existingProject == null)
            {
                return null;
            }

            _mapper.Map(projectDTO, existingProject);
            var updatedProject = await _projectRepository.UpdateAsync(existingProject);

            return _mapper.Map<ProjectDTO>(updatedProject);
        }

        public async Task<ProjectDTO> DeleteProjectAsync(int id)
        {
            var deletedProject = await _projectRepository.DeleteAsync(id);
            if (deletedProject == null)
            {
                return null;
            }

            return _mapper.Map<ProjectDTO>(deletedProject);
        }
        //**********//


    }
}
