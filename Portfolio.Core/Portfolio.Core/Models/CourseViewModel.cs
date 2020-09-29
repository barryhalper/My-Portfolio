using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class CourseViewModel : ICourse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set ; }
    }
}
