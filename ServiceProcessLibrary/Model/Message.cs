using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    public class Message
    {
        public int Id { get; set; }
        public string ClientsEmailAddress { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public string RepairersEmailAddress { get; set; }
        public DateTime Date { get; set; }
        public Enums.MessageStatus Status { get; set; }
    }
}
