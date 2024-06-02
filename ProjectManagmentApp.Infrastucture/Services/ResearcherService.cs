using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture.Services
{
    public class ResearcherService: IResearcherService
    {
        private readonly IResearcherRepository _researcherRepository;
        private readonly IMapper _mapper;

        public ResearcherService(IResearcherRepository researcherRepository, IMapper mapper)
        {
            _researcherRepository = researcherRepository;
            _mapper = mapper;
        }

        //***** CRUD METHODS *****//
        public async Task<List<ResearcherDTO>> GetResearchersAsync()
        {
            return await _researcherRepository
                 .GetAllAsync()
                 .ProjectTo<ResearcherDTO>(_mapper.ConfigurationProvider)
                 .ToListAsync();
        }

        public async Task<ResearcherDTO> GetResearcherAsync(int id)
        {
            var researcher = await _researcherRepository.GetByIdAsync(id);
            if (researcher == null)
            {
                return null;
            }

            return _mapper.Map<ResearcherDTO>(researcher);
        }

        public async Task<ResearcherDTO> CreateResearcherAsync(ResearcherDTO researcherDTO)
        {
            var researcher = _mapper.Map<Researcher>(researcherDTO);
            var createdResearcher = await _researcherRepository.CreateAsync(researcher);
            return _mapper.Map<ResearcherDTO>(createdResearcher);
        }

        public async Task<ResearcherDTO> UpdateResearcherAsync(int id, ResearcherDTO researcherDTO)
        {
            var existingResearcher = await _researcherRepository.GetByIdAsync(id);
            if (existingResearcher == null)
            {
                return null;
            }

            _mapper.Map(researcherDTO, existingResearcher);
            var updatedResearcher = await _researcherRepository.UpdateAsync(existingResearcher);

            return _mapper.Map<ResearcherDTO>(updatedResearcher);
        }

        public async Task<ResearcherDTO> DeleteResearcherAsync(int id)
        {
            var deletedResearcher = await _researcherRepository.DeleteAsync(id);
            if (deletedResearcher == null)
            {
                return null;
            }

            return _mapper.Map<ResearcherDTO>(deletedResearcher);
        }
        //**********//


    }
}
