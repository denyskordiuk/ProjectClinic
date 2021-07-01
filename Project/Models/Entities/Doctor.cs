using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Entities
{
    public class Doctor
    {
        public string License { get; set; }
        public string DoctorName { get; set; }
        public int Experience { get; set; }
        public string PhoneNumber { get; set; }
        public int Cabinet { get; set; }
        public DoctorStatus DoctorStatus { get; set; }
}
}