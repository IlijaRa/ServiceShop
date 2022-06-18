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
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public double Longevity { get; set; }
        public DateTime Birthday { get; set; }
        public Enums.RepairerRoles role { get; set; } = Enums.RepairerRoles.Repairer;
        public string SuperiorsEmailAddress { get; set; }
    }
}
