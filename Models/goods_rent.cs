using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class goods_rent
    {
        public int rent_id { get; set; }
        public int goods_id { get; set; }
        public int user_id { get; set; }
        public DateTime rent_time { get; set; }
    }
}
