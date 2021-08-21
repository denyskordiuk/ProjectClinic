using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Entities
{
    public class Order
    {
        [Key]
        public Guid id { get; set; }
        public DataType Time { get; set; }
        public DataType EndTime { get; set; }
        public string Problem { get; set; }
        public int Price { get; set; }
        public string ClientPhoneNumber { get; set; }
        [ForeignKey("ClientPhoneNumber")]
        public virtual Client Client { get; set; }
        public string DoctorLicense { get; set; }
        [ForeignKey("DoctorLicense")]
        public virtual Doctor Doctor { get; set; }

    }
}