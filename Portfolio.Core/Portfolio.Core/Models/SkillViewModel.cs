using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class SkillViewModel: ISkill
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public string Image { get; set; }

        public string Type { get; set; }

        public bool Home { get; set; }

        public int Order { get; set; }



        
    }
}
