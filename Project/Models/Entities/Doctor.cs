using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Entities
{
    public class Doctor
    {
        [Key]
        [RegularExpression(@"([0-9]){5}\d([A-Z]{1})", ErrorMessage = "Incorrect license number example(xxxxxxL")]
        public string License { get; set; }
        [Display(Name = "Doctor Name")]
        [RegularExpression(@"^([А-ЯA-Z]|[А-ЯA-Z][\x27а-яa-z]{1,}|[А-ЯA-Z][\x27а-яa-z]{1,}\-([А-ЯA-Z][\x27а-яa-z]{1,}|(оглы)|(кызы)))\040[А-ЯA-Z][\x27а-яa-z]{1,}(\040[А-ЯA-Z][\x27а-яa-z]{1,})?$", ErrorMessage = "Incorrect name example(Ivanov Ivan Ivanovich)")]
        public string DoctorName { get; set; }
        public int Experience { get; set; }
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\+?3?8?(0\d{9})$", ErrorMessage = "Incorrect phone number")]
        public string PhoneNumber { get; set; }
        public int Cabinet { get; set; }
        [Display(Name = "Doctor Status")]
        public DoctorStatus DoctorStatus { get; set; }
}
}