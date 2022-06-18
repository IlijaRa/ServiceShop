using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    public class Request
    {
        public int Id { get; set; }
        public string ClientsName { get; set; }
        public string ClientsSurname { get; set; }
        public string ClientsEmailAddress { get; set; }
        public string Description { get; set; }
        public Enums.RequestType request_type { get; set; }
        public Enums.StateType state_type { get; set; }
        public Enums.PaymentType payment_type { get; set; }
        public DateTime date { get; set; }
        public int BillName { get; set; }
        public int ClientId { get; set; }
        public int ReportId { get; set; }
        public int RepairerId { get; set; }
    }
}