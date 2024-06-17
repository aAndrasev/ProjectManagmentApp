using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Dtos
{
    public class ProjectClientDTO
    {
        public int? ClientId { get; set; }
        public int? ProjectId { get; set; }
        public string? Name { get; set; }
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmail { get; set; }
        public int? ContactPhoneNumber { get; set; }
    }
}
