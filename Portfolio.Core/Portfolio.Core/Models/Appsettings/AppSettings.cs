using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models.Appsettings
{
    //class to MODEL AppSettings from json
    public class AppSettings
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Lead { get; set; }

        public ContactSettings ContactSettings { get; set; }

        public BlogSettings BlogSettings { get; set; }

    }
}
