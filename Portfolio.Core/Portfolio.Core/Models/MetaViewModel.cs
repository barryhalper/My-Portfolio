﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class MetaViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }

        public string CanonicalUrl { get; set; }

        public bool ShowNavBackground { get; set; }
    }
}
