using System.Collections.Generic;

namespace Portfolio.Business.Models
{
    public interface IProject
    {
        string Id { get; set; }
        string Content { get; set; }
        string Description { get; set; }
       
        string Image { get; set; }
        string Name { get; set; }
        int    Order { get; set; }
        string Url { get; set; }
        IEnumerable<string> Skills { get; set; }

        string Video { get; set; }

        string GithubUrl { get; set; }



    }
}