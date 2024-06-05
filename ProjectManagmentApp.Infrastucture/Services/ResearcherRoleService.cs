using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Infrastucture.Services
{
    public class ResearcherRoleService: IResearcherRoleService
    {
        private readonly IResearcherRoleRepository _researcherRoleRepository;
        private readonly IMapper _mapper;

        public ResearcherRoleService(IResearcherRoleRepository researcherRoleRepository, IMapper mapper)
        {
            _researcherRoleRepository = researcherRoleRepository;
            _mapper = mapper;
        }

        //***** CRUD METHODS *****//
        public async Task<List<ResearcherRoleDTO>> GetResearcherRolesAsync()
        {
            return await _researcherRoleRepository
                 .GetAllAsync()
                 .ProjectTo<ResearcherRoleDTO>(_mapper.ConfigurationProvider)
                 .ToListAsync()
                 .ConfigureAwait(false);// dodati svuda kod awaita
        }
    }
}
