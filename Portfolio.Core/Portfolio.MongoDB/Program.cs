using Microsoft.Extensions.Configuration;
using MongoCrud;
using MongoDB.Bson;
using MongoDB.Driver;
using Portfolio.Business.DataAccess;
using System;
using System.Collections.Generic;

namespace Portfolio.MongoDBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseSettings databaseSettings = new DatabaseSettings();
            databaseSettings.ConnectionString = "mongodb+srv://zkhTXZt42Sb8ama6:zkhTXZt42Sb8ama6@cluster0.tdoch.mongodb.net/test?authSource=admin&replicaSet=atlas-rk8855-shard-0&readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=true";
            databaseSettings.DatabaseName = "Portfolio";

            ProjectCrud service = new ProjectCrud(databaseSettings);
            service.Insert();


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
