using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Entities
{
    public class Client
    {
        [Display(Name = "Full Name")]
        [RegularExpression(@"^([À-ßA-Z]|[À-ßA-Z][\x27à-ÿa-z]{1,}|[À-ßA-Z][\x27à-ÿa-z]{1,}\-([À-ßA-Z][\x27à-ÿa-z]{1,}|(îãëû)|(êûçû)))\040[À-ßA-Z][\x27à-ÿa-z]{1,}(\040[À-ßA-Z][\x27à-ÿa-z]{1,})?$", ErrorMessage = "Incorrect name example(Ivanov Ivan Ivanovich)")]
        public string FullName { get; set; }
        [RegularExpression(@"^(?:1(?:00?|\d)|[2-5]\d|[6-9]\d?)$", ErrorMessage = "Incorrect age")]
        public int Age { get; set; }
        public string Adress { get; set; }
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*)\@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])", ErrorMessage = "Incorrect mail example(example@gmail.com)")]
        public string Mail { get; set; }
        [Key]
        [RegularExpression(@"^\+?3?8?(0\d{9})$", ErrorMessage = "Incorrect phone number")]
        public string PhoneNumber { get; set; }
        public PayMethod PayMethod { get; set; }
    }
}