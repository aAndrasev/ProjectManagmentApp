using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Dtos.Requests;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;


namespace ProjectManagmentApp.Infrastucture.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IPhaseRepository _phaseRepository;
        private readonly IMapper _mapper;

        public ProjectService(IProjectRepository projectRepository, IMapper mapper, IPhaseRepository phaseRepository)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
            _phaseRepository = phaseRepository;
        }

        //***** CRUD METHODS *****//
        public async Task<List<ProjectDTO>> GetProjectsAsync(GetProjectsRequest request)
        {
            var result = _projectRepository
                 .GetAllAsync()
                 .ProjectTo<ProjectDTO>(_mapper.ConfigurationProvider);

            if (request.ProjectStatusId.HasValue && request.ProjectStatusId != 0)
            {
                result = result.Where(x => x.ProjectStatusId == request.ProjectStatusId);
            }
            if (!string.IsNullOrEmpty(request.SearchTerm))
            {
                result = result.Where(x => x.Name.Contains(request.SearchTerm));
            }

            return await result.ToListAsync();
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

            foreach (var phase in projectDTO.Phases)
            {
                await _phaseRepository.CreateAsync(new Phase
                {
                    Description = phase.Description,
                    Name = phase.Name,
                    ProjectId = createdProject.Id
                });
            }

            return _mapper.Map<ProjectDTO>(createdProject);
        }

        public async Task<ProjectDTO> UpdateProjectAsync(int id, ProjectDTO projectDTO)
        {
            var existingProject = await _projectRepository.GetByIdAsync(id);
            if (existingProject == null)
            {
                return null;
            }

            foreach (var phase in existingProject.Phases.Where(x => x.Id != 0))
            {
                var phaseExist =
                projectDTO.Phases
                    .Select(x => x.Id)
                    .Contains(phase.Id);

                if (phaseExist)
                {
                    await _phaseRepository.UpdateAsync(phase);
                    continue;
                }
                else
                {
                    await _phaseRepository.DeleteAsync(phase.Id);
                }
            }

         
            foreach (var phase in projectDTO.Phases.Where(x => x.Id == 0))
            {
                await _phaseRepository.CreateAsync(new Phase
                {
                    Description = phase.Description,
                    Name = phase.Name,
                    ProjectId = existingProject.Id
                });
            }

            _mapper.Map(projectDTO, existingProject);
            var updatedProject = await _projectRepository.UpdateAsync(existingProject);

            return _mapper.Map<ProjectDTO>(updatedProject);
        }

        public async Task DeleteProjectAsync(int id)
        {
            await _projectRepository.DeleteAsync(id);
        }
        //**********//


    }
}
