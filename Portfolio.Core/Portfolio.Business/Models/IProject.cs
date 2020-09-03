using System.Collections.Generic;

namespace Portfolio.Business.Models
{
    public interface IProject
    {
        string Id { get; set; }
        string Content { get; set; }
        string Description { get; set; }

        string Name { get; set; }
        int    Order { get; set; }

        IList<Media> Media { get; set; }


    }
}