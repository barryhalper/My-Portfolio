using MongoCrud;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using Portfolio.Business.Utils;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Portfolio.Business.DataAccess
{
    public class ArticleService : IArticleService
    {
        private MongoCrud.DataAccess mongoDb;
        //private string database;
        private const string table = "Article";
        public ArticleService(IDatabaseSettings databaseSettings)
        {
            mongoDb = new MongoCrud.DataAccess(databaseSettings);
        }


        public List<Article> Read()
        {
            return mongoDb.Read<Article>(table).ToList().OrderByDescending(x=>x.Published).ToList();
        }

        public Article ReadByTitle(string title)
        {
            return mongoDb.ReadByProperty<Article>(table, "UrlFriendlyTitle", title);
        }

        public void Upsert(IEnumerable<SyndicationItem> items)
        {

            var collection = mongoDb.GetCollection<Article>(table);
            var articles = collection.Find(new BsonDocument()).ToList();

            foreach (var item in items)
            {
                //call method to extract conent so does not run twice
                string content = item.GetContent();
                Article article = new Article
                {
                    Title = item.Title.Text,
                    RssGuid = item.Id,
                    Published = item.PublishDate.DateTime,
                    Content = item.GetContent(),
                    Image = item.GetFirstImage(),
                    Categories = item.Categories.Select(x => x.Name).ToArray(),
                    Link = item.Links[0].GetAbsoluteUri().ToString(),
                    Summary = content.StripHTML().FirstSentence().WordCut(155),
                    UrlFriendlyTitle = item.Title.Text.UrlFriendly()

                };


                //ReplaceOptions replaceOptions = new ReplaceOptions { IsUpsert = true };
                //var filter = Builders<Article>.Filter.Eq("RssGuid", item.Id);
                if (articles.Any(x => x.RssGuid == item.Id))
                {
                    string _id = articles.FirstOrDefault(x => x.RssGuid == item.Id).Id;
                    var filter = Builders<Article>.Filter.Eq("Id", _id);
                    article.Id = _id;
                    collection.ReplaceOne(filter, article);
                }
                else
                {
                    collection.InsertOne(article);
                }

            }

        }

    }




}
