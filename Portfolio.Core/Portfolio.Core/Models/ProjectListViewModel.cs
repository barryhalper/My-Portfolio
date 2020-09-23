using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class ProjectListViewModel
    {
        private IEnumerable<string> images;
        private const string path = "wwwroot/image/projects";

        public ProjectListViewModel()
        {
            this.images = System.IO.Directory.EnumerateFiles(path, "*.*", System.IO.SearchOption.AllDirectories).OrderBy(x=>x).AsEnumerable();
        }

        public IEnumerable<ProjectViewModel> Projects { get; set; }

        public IEnumerable<string> Images
        {
            get => this.images.Select(x => x.Replace(@"\", "/").Replace(path, "")).AsEnumerable();            
        }
    }
}
