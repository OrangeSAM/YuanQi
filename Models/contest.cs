using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class contest
    {
        public int contest_id { get; set; }
        public DateTime con_time { get; set; }
        public string con_place { get; set; }
        public string con_intro { get; set; }
        public int con_col { get; set; } 
        public string con_title { get; set; }
        
    }
}
