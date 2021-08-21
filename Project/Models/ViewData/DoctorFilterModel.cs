using Project.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.ViewData
{
    public class DoctorFilterModel
    {
        public string License { get; set; }
        public string PhoneNumber { get; set; }
        public DoctorStatuses? DoctorStatus { get; set; }
    }
}
