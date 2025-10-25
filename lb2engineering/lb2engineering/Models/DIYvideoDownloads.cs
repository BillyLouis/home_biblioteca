using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lb2engineering.Models
{
    public class DIYvideoDownloads
    {
        public int Id { get; set; } // how many times the book is downloaded
        public string Name { get; set; } // The correct name of the book not the name is saved as
        public string Details { get; set; } // not sure what this is one is for, i just need more parameters
    }
}