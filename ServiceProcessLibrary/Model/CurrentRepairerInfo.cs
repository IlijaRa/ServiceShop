using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    /// <summary>
    /// This class is going to be used to access basic info about repairer such as id, email, name etc.
    /// When repairer log in, basic info will be inserted in this classes fields
    /// </summary>
    public static class CurrentRepairerInfo
    {
        public static int Id { get; set; } = new int();
        public static string Name { get; set; } = new string('a', 1);
        public static string Surname { get; set; } = new string('a', 1);
        public static string EmailAddress { get; set; } = new string('a', 1);
        public static string Password { get; set; } = new string('a', 1);
        public static double Longevity { get; set; } = new double();
        public static DateTime Birthday { get; set; } = new DateTime();
        public static Enums.RepairerRoles role { get; set; }
        public static string SuperiorsEmailAddress { get; set; } = new string('a', 1);
    }
}
