using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Entities
{
    public class Order
    {
        public Guid id { get; set; }
        public DataType Time { get; set; }
        public DataType EndTime { get; set; }
        public string Problem { get; set; }
        public int Price { get; set; }
    }
}