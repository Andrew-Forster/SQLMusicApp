﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMusicApp
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
