using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Application.Interfaces.Repositories;

namespace ProjectManagmentApp.Infrastucture.Services
{
    public class ProjectStatusService: IProjectStatusService
    {
        private readonly IProjectStatusRepository _projectStatusRepository;
        private readonly IMapper _mapper;

        public ProjectStatusService(IProjectStatusRepository projectStatusRepository, IMapper mapper)
        {
            _projectStatusRepository = projectStatusRepository;
            _mapper = mapper;
        }

        //***** CRUD METHODS *****//
        public async Task<List<ProjectStatusDTO>> GetProjectStatusesAsync()
        {
            return await _projectStatusRepository
                 .GetAllAsync()
                 .ProjectTo<ProjectStatusDTO>(_mapper.ConfigurationProvider)
                 .ToListAsync()
                 .ConfigureAwait(false);// dodati svuda kod awaita
        }
    }
}
