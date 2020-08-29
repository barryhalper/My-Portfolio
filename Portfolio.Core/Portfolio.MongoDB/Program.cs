using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

using System;
using System.Collections.Generic;

namespace Portfolio.MongoDBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).AddCommandLine(args).Build();

            var DatabaseSettting = Configuration.GetSection("DatabaseSettings");

            //SkillsCrud skills = new SkillsCrud();
            //skills.Update();


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
