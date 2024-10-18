using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMusicApp
{
    public class Track
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Number { get; set; }
        public string VideoUrl { get; set; }
        public string Lyrics { get; set; }
        public int AlbumID { get; set; }
    }
}
