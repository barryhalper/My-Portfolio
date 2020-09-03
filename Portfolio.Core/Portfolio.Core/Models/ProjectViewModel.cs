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
       
        public string Name { get; set; }

        public int Order { get; set; }

        public IList<Media> Media { get ; set; }


        public IEnumerable<Media> GetMediaByType(string category) {
            return Media.Where(x => x.Category == category).AsEnumerable();
          
        }

       public string ImageFolderName {
            get {
                return $"{Name.Replace(" ", "-")}".ToLower();
            }
        }

         public string FirstImage
        {
            get
            {
                return ($"{ImageFolderName}/{GetMediaByType("Image").FirstOrDefault().File}");
            }

        }

        public IEnumerable<string> GetImages(IEnumerable<string> images)
        {
            string path = ($"/{Name.Replace(" ", "-").ToLower()}");
            return images.Where(x => x.StartsWith(path)).AsEnumerable();


        }

        public string Video {
            get {
                return GetMediaByType("Video").Where(x => !String.IsNullOrEmpty(x.File)).FirstOrDefault().File;
            }
        }
    }
}
