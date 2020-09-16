using Portfolio.Business.Models;
using System.Collections.Generic;
using System.ServiceModel.Syndication;

namespace Portfolio.Business.DataAccess
{
    public interface IArticleService
    {
        List<Article> Read();
        Article ReadByTitle(string title);
        void Upsert(IEnumerable<SyndicationItem> items);
    }
}