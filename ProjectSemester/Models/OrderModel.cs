using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSemester.Models
{
    public class OrderModel
    {
        public byte id { get; set; }
        public int OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string FIO { get; set; }
        public string Address { get; set; }
    }
}

