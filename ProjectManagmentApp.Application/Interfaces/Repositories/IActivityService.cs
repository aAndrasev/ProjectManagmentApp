using ProjectManagmentApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IActivityService
    {
        Task<List<ActivityDTO>> GetActivitiesAsync();
        Task<ActivityDTO> GetActivityAsync(int id);
        Task<ActivityDTO> CreateActivityAsync(ActivityDTO activityDTO);
        Task<ActivityDTO> UpdateActivityAsync(int id, ActivityDTO activityDTO);
        Task<ActivityDTO> DeleteActivityAsync(int id);
    }
}
