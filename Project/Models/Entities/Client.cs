using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Entities
{
    public class Client
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public PayMethod PayMethod { get; set; }
    }
}