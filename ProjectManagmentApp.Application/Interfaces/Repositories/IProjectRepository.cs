﻿using ProjectManagmentApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        ProjectDTO GetById(int id);
    }
}
