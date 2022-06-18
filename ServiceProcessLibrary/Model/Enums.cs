using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    public class Enums
    {
        public enum RepairerRoles
        {
            Repairer,
            MainRepairer
        }

        public enum RequestType
        {
            purhcasement,
            repairment
        }

        public enum PaymentType
        {
            cash,
            card,
            check
        }

        public enum StateType
        {
            not_forwarded,
            in_progress,
            finished
        }

        public enum JobOutcome
        {
            unsuccessful,
            successful
        }
    }
}
