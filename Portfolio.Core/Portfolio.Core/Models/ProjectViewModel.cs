using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Business.DataAccess;
using Portfolio.Business.Models;

namespace Portfolio.Core.Models
{
    public class ProjectViewModel : IProject
    {
        public string Content { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int PubSeq { get; set; }
        public string Url { get; set; }
        public IEnumerable<string> Skills { get; set; }

        public int Order { get; set; }

        public string Video { get; set; }

        public string GithubUrl { get; set; }


    }
}
