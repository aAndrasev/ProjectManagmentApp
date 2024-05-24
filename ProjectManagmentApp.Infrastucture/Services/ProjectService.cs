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
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public ProjectDTO GetProject()
        {
            _projectRepository.GetById(2);
            throw new NotImplementedException();
        }
    }
}
