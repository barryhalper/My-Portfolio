using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class ArticleViewModel : IArticle
    {
        public string[] Categories { get ; set ; }
        public string Content { get ; set ; }
        public string Id { get ; set ; }
        public string Image { get ; set ; }
        public string Link { get ; set ; }
        public DateTime Published { get ; set ; }
        public string RssGuid { get ; set ; }
        public string Title { get ; set ; }
    }
}
