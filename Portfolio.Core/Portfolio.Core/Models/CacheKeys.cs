using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    //class to hold constants of cache keys
    public static class CacheKeys
    {
        public static string Home { get { return "_Home"; } }
        public static string Courses { get { return "_Courses"; } }
        public static string Skills { get { return "_Skills"; } }
        public static string Projects { get { return "_Projects"; } }

        public static string Testimonials { get { return "_Testimonials"; } }
    }
}
