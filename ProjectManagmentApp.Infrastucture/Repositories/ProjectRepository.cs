using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Infrastucture.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext applicationDbContext)
        {

        }

        public ProjectDTO GetById(int id)
        {
            //applicationDbContext.getbyid
            throw new NotImplementedException();
        }
    }
}
