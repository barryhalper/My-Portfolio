using System.Collections.Generic;
using System.ServiceModel.Syndication;

namespace Portfolio.Business.DataAccess
{
    public interface IRssService
    {
       
        IEnumerable<SyndicationItem> Read(string url);
    }
}