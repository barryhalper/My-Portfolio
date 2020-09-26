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


        public void Insert(IEnumerable<SyndicationItem> items) {
            //call mong crud repository to get collection
            var collection = mongoDb.GetCollection<Article>(table);

            var articles = collection.Find(new BsonDocument()).ToList();
            //loop over content
            foreach (var item in items)
            {
                Article article = LoadFromItem(item);


                //check if article already existing using RSS Guid (NOT row GUID)
                if (articles.Any(x => x.RssGuid != item.Id))
                //do insert
                {
                    collection.InsertOne(article);
                }

            }
        }

        private static Article LoadFromItem(SyndicationItem item)
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
                Categories = item.Categories.Select(x => x.Name).ToArray(),//extract content using extension method
                Link = item.Links[0].GetAbsoluteUri().ToString(), //extract link using extension methods
                Summary = content.StripHTML().FirstSentence().WordCut(155), //extract summary using extension method
                UrlFriendlyTitle = item.Title.Text.UrlFriendly() //extract url using extension method

            };
            return article;
        }

        //perform insert/update on content 
        public void Upsert(IEnumerable<SyndicationItem> items)
        {

            //call mong crud repository to get collection
            var collection = mongoDb.GetCollection<Article>(table);
            
            var articles = collection.Find(new BsonDocument()).ToList();
            //loop over content
            foreach (var item in items)
            {
                Article article = LoadFromItem(item);
                //check if article already existing using RSS Guid (NOT row GUID)
                if (articles.Any(x => x.RssGuid == item.Id))
                {
                    
                    string _id = articles.FirstOrDefault(x => x.RssGuid == item.Id).Id;
                    var filter = Builders<Article>.Filter.Eq("Id", _id);
                    article.Id = _id;
                    //it exists so update
                    collection.ReplaceOne(filter, article);
                }
                else // do insert
                {
                    collection.InsertOne(article);
                }

            }

        }

    }




}
