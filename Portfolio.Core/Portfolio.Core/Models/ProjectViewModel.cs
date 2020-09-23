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
        private IEnumerable<String> images;


        public IEnumerable<Media> GetMediaByType(string category) {
            return Media.Where(x => x.Category == category).AsEnumerable();
          
        }

       public string ImageFolderName {
           
                get=> $"{Name.Replace(" ", "-")}".ToLower();
            
        }

         public string FirstImage
        {
              
              get=> ($"{GetMediaByType("Image").FirstOrDefault().File}");
            

        }

        public IEnumerable<string> GetImages(IEnumerable<string> images)
        {
            string path = ($"/{Name.Trim().Replace(" ", "-").ToLower()}");
            //filter list of images to NOT inlcude 1st one
            return images.Where(x => x.StartsWith(path)).Where(x=>x!= FirstImage).AsEnumerable();


        }

        public string Video {
            get => GetMediaByType("Video").Where(x => !String.IsNullOrEmpty(x.File)).FirstOrDefault().File;
                   
        }

        public IEnumerable<string> Images {
           
               get=> images;
           

               set => images = GetImages(value);
            
        }

        public string IsActive(int currentPosition) {
            return (currentPosition == 0) ? "active" : String.Empty;
        }
    }
}
