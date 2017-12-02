using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class album
    {
        public int album_id { get; set; }
        public int creater_id { get; set; }
        public DateTime create_time { get; set; }
        public string album_intro { get; set; }
        public int photo_amount { get; set; }
        public string photo { get; set; }
    }
}
