using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public interface IType
    {
         int Order { get; set; }
         string Type { get; set; }
    }
}
