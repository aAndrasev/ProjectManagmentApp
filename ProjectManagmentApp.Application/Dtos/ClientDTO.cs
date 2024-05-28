using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Dtos
{
    public class ClientDTO
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string Email { get; set; }
        public int? PhoneNumber { get; set; }
    }
}
