using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class goods
    {
        public int goods_id { get; set; }
        public int type_id { get; set; }
        public string goods_name { get; set; }
        public decimal goods_price { get; set;}
        public int store_id { get; set; }
        public string goods_intro { get; set; }
        public string stock { get; set; }
    }
}
