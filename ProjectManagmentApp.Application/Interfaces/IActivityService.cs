using ProjectManagmentApp.Application.Dtos;

namespace ProjectManagmentApp.Application.Interfaces
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
