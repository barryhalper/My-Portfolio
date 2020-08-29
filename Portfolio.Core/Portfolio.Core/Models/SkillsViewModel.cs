using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class SkillsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public string Image { get; set; }

        public string Type { get; set; }

        public bool Home { get; set; }
    }
}
