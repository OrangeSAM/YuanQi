using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class album_photos
    {
        public int photos_id { get; set; }
        public string photo { get; set; }
        public int col_count { get; set; }
        public int like_count { get; set; }
        public int album_id { get; set; }

    }
}
