﻿using AutoMapper;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Infrastucture.Mapping_profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Project, ProjectDTO>()
             .ForMember(dest => dest.ProjectStatusName, opt => opt.MapFrom(src => src.ProjectStatus.Name));
            
            CreateMap<ProjectDTO, Project>();
            CreateMap<Researcher, ResearcherDTO>();
            CreateMap<ResearcherDTO, Researcher>();
            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();
            CreateMap<Phase, PhaseDTO>();
            CreateMap<PhaseDTO, Phase>();
            CreateMap<Activity, ActivityDTO>();
            CreateMap<ActivityDTO, Activity>();
            CreateMap<ProjectStatusDTO, ProjectStatus>();
            CreateMap<ProjectStatus, ProjectStatusDTO>();
        }
    }
}
