using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class contest_news
    {
        public int news_id { get; set;}
        public DateTime pub_time { get; set; }
        public string news_cont { get; set; }
        public string news_title { get; set; }
    }
}
