using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class AboutItemViewModel : IAbout, IType
    {
        public string Desc { get; set; }
        public string Id { get; set; }
        public int Order { get; set; }
        public string Type { get; set; }
    }
}
