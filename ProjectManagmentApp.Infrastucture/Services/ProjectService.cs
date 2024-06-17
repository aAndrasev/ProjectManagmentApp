using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Dtos.Requests;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;
using ProjectManagmentApp.Infrastucture.Repositories;


namespace ProjectManagmentApp.Infrastucture.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IPhaseRepository _phaseRepository;
        private readonly IProjectResearcherRepository _projectResearcherRepository;
        private readonly IProjectClientRepository _projectClientRepository;
        private readonly IMapper _mapper;

        public ProjectService(IProjectRepository projectRepository, IMapper mapper, IPhaseRepository phaseRepository, IProjectResearcherRepository projectResearcherRepository, IProjectClientRepository projectClientRepository)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
            _phaseRepository = phaseRepository;
            _projectResearcherRepository = projectResearcherRepository;
            _projectClientRepository = projectClientRepository;
        }

        //***** CRUD METHODS *****//
        public async Task<List<ProjectDTO>> GetProjectsAsync(GetProjectsRequest request)
        {
            try
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
            catch (Exception ex)
            {
               
                throw;
            }
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

            try
            {
                var project = new Project
                {
                    Name = projectDTO.Name,
                    Description = projectDTO.Description,
                    StartDate = projectDTO.StartDate,
                    EndDate = projectDTO.EndDate,
                    DateOfCreation = projectDTO.DateOfCreation,
                    PlannedStartDate = projectDTO.PlannedStartDate,
                    PlannedEndDate = projectDTO.PlannedEndDate,
                    ProjectStatusId = projectDTO.ProjectStatusId
                };
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

                foreach (var researcher in projectDTO.ProjectResearchers)
                {
                    await _projectResearcherRepository.CreateAsync(new ProjectResearcher
                    {
                        ResearcherId = researcher.ResearcherId.Value,
                        ProjectId = project.Id,
                        StartDate = researcher.StartDate,
                        EndDate = researcher.EndDate,
                        ResearcherRoleId = 1 // change this to use researcher.ResearcherRoleId
                    });
                }

                foreach (var client in projectDTO.ProjectClients)
                {
                    await _projectClientRepository.CreateAsync(new ProjectClient
                    {
                        ClientId = client.ClientId.Value,
                        ProjectId = project.Id,
                        ContactName = client.ContactName,
                        ContactLastName = client.ContactLastName,
                        ContactEmail = client.ContactEmail,
                        ContactPhoneNumber = client.ContactPhoneNumber,
                    });
                }

                return _mapper.Map<ProjectDTO>(createdProject);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while creating the project.", ex);
            }
        }

        public async Task<ProjectDTO> UpdateProjectAsync(int id, ProjectDTO projectDTO)
        {
            var existingProject = await _projectRepository.GetByIdAsync(id);
            if (existingProject == null)
            {
                return null;
            }

            await UpsertPhases(projectDTO, existingProject);
            await UpsertProjectResearchers(projectDTO, existingProject);
            await UpsertProjectClients(projectDTO, existingProject);

            _mapper.Map(projectDTO, existingProject);
            var updatedProject = await _projectRepository.UpdateAsync(existingProject);

            return _mapper.Map<ProjectDTO>(updatedProject);
        }

        private async Task UpsertPhases(ProjectDTO projectDTO, Project? existingProject)
        {
            foreach (var phase in existingProject.Phases.Where(x => x.Id != 0))
            {
                var phaseExist =
                projectDTO.Phases
                    .Select(x => x.Id)
                    .Contains(phase.Id);

                if (phaseExist)
                {
                    await _phaseRepository.UpdateAsync(phase);

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
        }

        private async Task UpsertProjectResearchers(ProjectDTO projectDTO, Project? existingProject)
        {
            foreach (var projectResearcher in existingProject.ProjectResearchers)
            {
                var projectResearcherExist =
                projectDTO.ProjectResearchers
                    .Select(x => x.ResearcherId)
                    .Contains(projectResearcher.ResearcherId);

                if (projectResearcherExist)
                {
                    await _projectResearcherRepository.UpdateAsync(projectResearcher);

                }
                else
                {
                    await _projectResearcherRepository.DeleteAsync(existingProject.Id, projectResearcher.ResearcherId);
                }
            }


            foreach (var projectResearcherDTO in projectDTO.ProjectResearchers.Where(x => x.ProjectId == 0))
            {
                await _projectResearcherRepository.CreateAsync(new ProjectResearcher
                {
                    ResearcherId = projectResearcherDTO.ResearcherId.Value,
                    ProjectId = existingProject.Id,
                    StartDate = projectResearcherDTO.StartDate,
                    EndDate = projectResearcherDTO.EndDate,
                    ResearcherRoleId = 1 // change this to use researcher.ResearcherRoleId
                });
            }
        }
        private async Task UpsertProjectClients(ProjectDTO projectDTO, Project? existingProject)
        {
            foreach (var projectClient in existingProject.ProjectClients)
            {
                var projectClientExist =
                projectDTO.ProjectClients
                    .Select(x => x.ClientId)
                    .Contains(projectClient.ClientId);

                if (projectClientExist)
                {
                    await _projectClientRepository.UpdateAsync(projectClient);

                }
                else
                {
                    await _projectClientRepository.DeleteAsync(existingProject.Id, projectClient.ClientId);
                }
            }


            foreach (var projectClientDTO in projectDTO.ProjectClients.Where(x => x.ProjectId == 0))
            {
                await _projectClientRepository.CreateAsync(new ProjectClient 
                {
                    ClientId = projectClientDTO.ClientId.Value,
                    ProjectId = existingProject.Id,
                    ContactName = projectClientDTO.ContactName,
                    ContactLastName = projectClientDTO.ContactLastName,
                    ContactEmail = projectClientDTO.ContactEmail,
                    ContactPhoneNumber = projectClientDTO.ContactPhoneNumber.Value,
                });
            }
        }

        public async Task DeleteProjectAsync(int id)
        {
            await _projectRepository.DeleteAsync(id);
        }
        //**********//

        public async Task<List<ProjectResearcherDTO>> GetProjectResearchersAsync()
        {
            var result = _projectResearcherRepository
                 .GetAllAsync()
                 .ProjectTo<ProjectResearcherDTO>(_mapper.ConfigurationProvider);

            return await result.ToListAsync();
        }
        public async Task<List<ProjectClientDTO>> GetProjectClientsAsync()
        {
            var result = _projectClientRepository
                 .GetAllAsync()
                 .ProjectTo<ProjectClientDTO>(_mapper.ConfigurationProvider);

            return await result.ToListAsync();
        }
    }
}
