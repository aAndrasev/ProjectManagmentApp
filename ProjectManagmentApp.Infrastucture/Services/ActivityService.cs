using AutoMapper.QueryableExtensions;
using AutoMapper;
using ProjectManagmentApp.Application.Dtos;
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
    public class ActivityService: IActivityService
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IMapper _mapper;

        public ActivityService(IActivityRepository activityRepository, IMapper mapper)
        {
            _activityRepository = activityRepository;
            _mapper = mapper;
        }

        //***** CRUD METHODS *****//
        public async Task<List<ActivityDTO>> GetActivitiesAsync()
        {
            return await _activityRepository
                 .GetAllAsync()
                 .ProjectTo<ActivityDTO>(_mapper.ConfigurationProvider)
                 .ToListAsync();
        }

        public async Task<ActivityDTO> GetActivityAsync(int id)
        {
            var activity = await _activityRepository.GetByIdAsync(id);
            if (activity == null)
            {
                return null;
            }

            return _mapper.Map<ActivityDTO>(activity);
        }

        public async Task<ActivityDTO> CreateActivityAsync(ActivityDTO activityDTO)
        {
            var activity = _mapper.Map<Activity>(activityDTO);
            var createdActivity = await _activityRepository.CreateAsync(activity);
            return _mapper.Map<ActivityDTO>(createdActivity);
        }

        public async Task<ActivityDTO> UpdateActivityAsync(int id, ActivityDTO activityDTO)
        {
            var existingActivity = await _activityRepository.GetByIdAsync(id);
            if (existingActivity == null)
            {
                return null;
            }

            _mapper.Map(activityDTO, existingActivity);
            var updatedActivity = await _activityRepository.UpdateAsync(existingActivity);

            return _mapper.Map<ActivityDTO>(updatedActivity);
        }

        public async Task<ActivityDTO> DeleteActivityAsync(int id)
        {
            var deletedActivity = await _activityRepository.DeleteAsync(id);
            if (deletedActivity == null)
            {
                return null;
            }

            return _mapper.Map<ActivityDTO>(deletedActivity);
        }
        //**********//


    }
}
