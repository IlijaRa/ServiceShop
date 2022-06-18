using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    /// <summary>
    /// This class is going to be used to access basic info about client such as id, email, name etc.
    /// When cient log in, basic info will be inserted in this classes fields
    /// </summary>
    public static class CurrentClientInfo
    {
        public static int Id { get; set; } = new int();
        public static string Name { get; set; } = new string('a', 1);
        public static string Surname { get; set; } = new string('a', 1);
        public static string EmailAddress { get; set; } = new string('a', 1);
        public static string Password { get; set; } = new string('a', 1);
        public static string DeliveryAddress { get; set; } = new string('a', 1);
        public static string DeliveryCity { get; set; } = new string('a', 1);
        public static string PostalCode { get; set; } = new string('a', 1);
        public static DateTime Birthday { get; set; } = new DateTime();
        public static string PhoneNumber { get; set; } = new string('a', 1);
    }
}
