using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class indent_detail
    {
        public int detail_id { get; set; }
        public int indent_id { get; set; }
        public int goods_id { get; set; }
        public float unit_price { get; set; }
        public int number { get; set; }
        public float total_price { get; set; }
        public string payway { get; set; }
        
        
    }
}
