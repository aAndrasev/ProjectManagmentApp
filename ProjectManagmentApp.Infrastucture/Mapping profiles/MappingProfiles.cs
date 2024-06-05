using AutoMapper;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture.Mapping_profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Project, ProjectDTO>()
             .ForMember(dest => dest.ProjectStatusName, opt => opt.MapFrom(src => src.ProjectStatus.Name));
            
            CreateMap<ProjectDTO, Project>();
            
            CreateMap<Researcher, ResearcherDTO>()
            .ForMember(dest => dest.ResearcherRoleName, opt => opt.MapFrom(src => src.ResearcherRole.Name));
            
            CreateMap<ResearcherDTO, Researcher>();
            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();
            CreateMap<Phase, PhaseDTO>();
            CreateMap<PhaseDTO, Phase>();
            CreateMap<Activity, ActivityDTO>();
            CreateMap<ActivityDTO, Activity>();
            CreateMap<ProjectStatusDTO, ProjectStatus>();
            CreateMap<ProjectStatus, ProjectStatusDTO>();
            CreateMap<ResearcherRoleDTO, ResearcherRole>();
            CreateMap<ResearcherRole, ResearcherRoleDTO>();
        }
    }
}
