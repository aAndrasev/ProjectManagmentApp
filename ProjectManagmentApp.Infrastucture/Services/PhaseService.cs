using AutoMapper.QueryableExtensions;
using AutoMapper;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectManagmentApp.Infrastucture.Services
{
    public class PhaseService: IPhaseService
    {
        private readonly IPhaseRepository _phaseRepository;
        private readonly IMapper _mapper;

        public PhaseService(IPhaseRepository phaseRepository, IMapper mapper)
        {
            _phaseRepository = phaseRepository;
            _mapper = mapper;
        }

        //***** CRUD METHODS *****//
        public async Task<List<PhaseDTO>> GetPhasesAsync()
        {
            return await _phaseRepository
                 .GetAllAsync()
                 .ProjectTo<PhaseDTO>(_mapper.ConfigurationProvider)
                 .ToListAsync();
        }

        public async Task<PhaseDTO> GetPhaseAsync(int id)
        {
            var phase = await _phaseRepository.GetByIdAsync(id);
            if (phase == null)
            {
                return null;
            }

            return _mapper.Map<PhaseDTO>(phase);
        }

        public async Task<PhaseDTO> CreatePhaseAsync(PhaseDTO phaseDTO)
        {
            var phase = _mapper.Map<Phase>(phaseDTO);
            var createdPhase = await _phaseRepository.CreateAsync(phase);
            return _mapper.Map<PhaseDTO>(createdPhase);
        }

        public async Task<PhaseDTO> UpdatePhaseAsync(int id, PhaseDTO phaseDTO)
        {
            var existingPhase = await _phaseRepository.GetByIdAsync(id);
            if (existingPhase == null)
            {
                return null;
            }

            _mapper.Map(phaseDTO, existingPhase);
            var updatedPhase = await _phaseRepository.UpdateAsync(existingPhase);

            return _mapper.Map<PhaseDTO>(updatedPhase);
        }

        public async Task<PhaseDTO> DeletePhaseAsync(int id)
        {
            var deletedPhase = await _phaseRepository.DeleteAsync(id);
            if (deletedPhase == null)
            {
                return null;
            }

            return _mapper.Map<PhaseDTO>(deletedPhase);
        }
        //**********//


    }
}
