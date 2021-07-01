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
        [Display(Name = "Doctor Name")]
        public string DoctorName { get; set; }
        public int Experience { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public int Cabinet { get; set; }
        [Display(Name = "Doctor Status")]
        public DoctorStatus DoctorStatus { get; set; }
}
}