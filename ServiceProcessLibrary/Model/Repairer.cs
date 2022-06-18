using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    public class Repairer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public double Longevity { get; set; }
        public DateTime Birthday { get; set; }
        public Enums.Roles role { get; set; } = Enums.Roles.Repairer;
        public string SuperiorEmail { get; set; }
    }
}
