using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class SkillsViewModel
    {
        public IEnumerable<SkillViewModel> Skills { get; set; }

        public string [] Types {
            get {
               return Skills.GroupBy(x => x.Type).Select(g => g.Key.ToString()).ToArray();
            }
        }

        public IEnumerable<SkillViewModel> Filter(string type) {
            return Skills.OrderBy(x=>x.Order).Where(x => x.Type == type).AsEnumerable();


        }

    }
}
