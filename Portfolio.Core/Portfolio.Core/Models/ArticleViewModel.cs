using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Business.Utils;

namespace Portfolio.Core.Models
{
    public class ArticleViewModel : IArticle
    {
        private string urlPath;
        private string fullPath;

        public string[] Categories { get; set; }
        public string Content { get; set; }
        public string Id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }

        public string Summary { get; set; }
        public DateTime Published { get; set; }
        public string RssGuid { get; set; }
        public string Title { get; set; }

        public string UrlFriendlyTitle { get; set; }

        public string UrlPath
        {
            get => urlPath;
            set => urlPath = $"Blog/{value.UrlFriendly()}";
        }

        public string FullPath
        {

            get => fullPath;
            set => fullPath = value;
        }
    }
}
