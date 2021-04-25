using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSemester.Models
{
    public class WeaponModel
    {
        public byte id { get; set; }
        public string name { get; set; }
        public string calibr { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int categoryId { get; set; }
        public bool rifle { get; set; }
        public string image { get; set; }
    }
}
