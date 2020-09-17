using Microsoft.Extensions.Configuration;
using MongoCrud;
using MongoDB.Bson;
using MongoDB.Driver;
using Portfolio.Business.DataAccess;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.MongoDBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseSettings databaseSettings = new DatabaseSettings();
            databaseSettings.ConnectionString = "mongodb+srv://zkhTXZt42Sb8ama6:zkhTXZt42Sb8ama6@cluster0.tdoch.mongodb.net/test?authSource=admin&replicaSet=atlas-rk8855-shard-0&readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=true";
            databaseSettings.DatabaseName = "Portfolio";

            //AboutCrud service = new AboutCrud(databaseSettings);
            //service.Insert();
            RssService rssService = new RssService();
            var items =rssService.Read("https://medium.com/feed/@jakubgarfield");

            ArticleService articleService = new ArticleService(databaseSettings);
            articleService.Upsert(items);

            // Console.WriteLine(items.Count());

            //foreach (var i in items)
            //{
            //    Console.WriteLine(i.Title.Text);
            //    Console.WriteLine(rssService.GetContent(i));
            //    Console.WriteLine(i.Summary.Text);
            //    Console.WriteLine(i.Id);
            //    Console.WriteLine(i.PublishDate.DateTime);
            //    Console.WriteLine(i.SourceFeed);
            //    Console.WriteLine(i.Links[0].GetAbsoluteUri().ToString());
            //    Console.WriteLine(rssService.GetFirstImage(i));
            //    Console.WriteLine("--done--");
            //}

            //var mongodb = new MongoCrud.DataAccess(databaseSettings);

            //Project record = mongodb.ReadById<Project>("Projects", "5f4f97e6dd417c13cd30f044");

            //record.Media = new List<Media>();
            //record.Media.Add(new Media { Category = "Video", Url = "https://player.vimeo.com/video/277472536?api=1&amp;player_id=vvvvimeoVideo-0" });
            //record.Media.Add(new Media { Category = "Video", File = "MYB-public-spend.mp4" });

            //record.Media.Add(new Media { Category = "Url", Url = "https://www.mybpublicspend.com/" });
            // record.Media.Add(new Media
            // {
            //     Category = "Image",
            //     File = "myb-public-spend.png"
            // });

            //record.Media.Add(new Media
            //{
            //    Category = "GitHub",
            //    Url = ""
            //});



            //mongodb.Upsert<Project>("Projects", "5f4f97e6dd417c13cd30f044", record);

            //var businesss = new Business.DataAccess.SkillService("Portfolio", "Skills");
            //businesss.Insert();
            //MongoCrud db = new MongoCrud("Portfolio");
            //    db.Create("Skills", new Skill { Name = "test 2", Home = false, Desc = "", Image = "*", Order = 2, skillType = new SkillType { Name = "Language" } });
            //    Console.ReadLine();
            //}
            //    db.Create("Skills", new Skill { Name = "test 2", Home = false, Desc = "", Image = "*", Order = 2, skillType = new SkillType { Name = "Language" } });
            //var skiils = db.Read<Skill>("Skills");

            //foreach (var i in skiils)
            //{
            //    Console.WriteLine($"{i.Name}: {i.Id}");
            //}

            //var skill = db.ReadById<Skill>("Skills", new Guid("dd24dd77-ba7e-4b95-995d-e5dff0c63ad3"));

            //Console.WriteLine($"{skill.Name}: {skill.Id}");



            Console.WriteLine("--done--");
            Console.ReadLine();
        }
    }

  
}
