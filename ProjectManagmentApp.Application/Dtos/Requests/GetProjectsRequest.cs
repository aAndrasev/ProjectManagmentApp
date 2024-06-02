using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Dtos.Requests
{
    public class GetProjectsRequest    
    {
        public int? ProjectStatusId { get; set; }
        public string? SearchTerm { get; set; }
    }
}
