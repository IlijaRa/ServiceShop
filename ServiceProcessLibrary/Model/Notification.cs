using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    public class Notification
    {
        public int Id { get; set; }
        public string ClientsEmailAddress { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int BillId { get; set; }
        public int RepairerId { get; set; }
    }
}
