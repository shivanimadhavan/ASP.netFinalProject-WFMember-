﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WFM_FinalProject.Models
{
    public class WfmMember
    {
        public int EmpId { get; set; }
        public string? Requestee { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string? EmployeeManager { get; set; }
        public string? RequestMessage { get; set; }
    }
}
