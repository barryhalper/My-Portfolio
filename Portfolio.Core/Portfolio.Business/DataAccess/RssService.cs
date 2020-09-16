using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Portfolio.Business.DataAccess
{
    public class RssService : IRssService
    {
        private string url;

        public RssService()
        {
          
        }

        public IEnumerable<SyndicationItem> Read(string url)
        {
            var reader = XmlReader.Create(url);
            return SyndicationFeed.Load(reader).Items;


        }

        

       

    }
}
