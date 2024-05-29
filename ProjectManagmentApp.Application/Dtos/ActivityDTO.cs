using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Dtos
{
    public class ActivityDTO
    {
        public int Id { get; set; }
        public int PhaseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
