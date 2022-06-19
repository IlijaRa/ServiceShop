using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    public class JobHistory
    {
        public int Id { get; set; }
        public string ClientsEmailAddress { get; set; }
        public string RepairersEmailAddress { get; set; }
        public string RequestDescription { get; set; }
        public Enums.JobOutcome Outcome { get; set; }
    }
}
