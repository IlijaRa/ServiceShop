using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    public class Bill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnterpriseName { get; set; }
        public string EnterpriseAddress { get; set; }
        public string ClientsName { get; set; }
        public string ClientsSurname { get; set; }
        public string ClientsEmailAddress { get; set; }
        public double Price { get; set; }
        public string SpentMaterials { get; set; }
        public string TermsAndConditions { get; set; }
        public int RepairerId { get; set; }
    }
}
