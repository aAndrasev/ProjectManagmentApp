﻿using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IResearcherRoleRepository
    {
        IQueryable<ResearcherRole> GetAllAsync();
    }
}
