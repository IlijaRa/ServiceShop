﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.Model
{
    public class Report
    {
        public int Id { get; set; }
        public string ClientsEmailAddress { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int Mark { get; set; }
        public int RepairerId { get; set; }
    }
}
