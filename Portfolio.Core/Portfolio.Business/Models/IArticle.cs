using System;

namespace Portfolio.Business.Models
{
    public interface IArticle
    {
        string[] Categories { get; set; }
        string Content { get; set; }
        string Id { get; set; }
        string Image { get; set; }

        string Summary { get; set; }
        string Link { get; set; }
        DateTime Published { get; set; }
        string RssGuid { get; set; }
        string Title { get; set; }

        string UrlFriendlyTitle { get; set; }

    }
}