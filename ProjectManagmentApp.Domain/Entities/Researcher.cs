using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Domain.Entities
{
    public class Researcher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public int? PhoneNumber { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
