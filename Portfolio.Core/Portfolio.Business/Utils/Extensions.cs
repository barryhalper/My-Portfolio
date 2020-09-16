using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml.Linq;

namespace Portfolio.Business.Utils
{
    public static class SyndicationExtensions
    {

        public static string GetContent(this SyndicationItem item)
        {
            foreach (var ext in item.ElementExtensions)
            {
                if (ext.GetObject<XElement>().Name.LocalName == "encoded")
                {
                    return ext.GetObject<XElement>().Value;

                }
            }

            return String.Empty;

        }

        public static string GetFirstImage(this SyndicationItem item)
        {
            string content = GetContent(item);
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(content);
            var node = htmlDoc.DocumentNode.SelectSingleNode("//img");
            return (node == null) ? String.Empty : node.Attributes["src"].Value;

        }
    }
}
