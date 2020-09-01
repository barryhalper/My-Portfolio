using MongoCrud;
using MongoDB.Bson.Serialization.Attributes;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.MongoDBConsole
{
 


    public class SkillsCrud
    {
        private MongoCrud.DataAccess mongodb;
        public SkillsCrud(IDatabaseSettings databaseSettings) {
            mongodb = new MongoCrud.DataAccess(databaseSettings);

        }


       

        //public void Update() {
         
        //    var skills = mongodb.Read<Skill>("Skills");


        //    for (var i = 0; i < skills.Count; i++)
        //    {
        //        skills[i].Home = true;
        //        mongodb.Upsert<Skill>("Skills", skills[i].Id, skills[i]);
        //    }
        //}



        public void Insert()
        {
            List<Skill> skills = new List<Skill>();
            string skilltype = "Languages";


            skills.Add(new Skill { Image = "c-sharp.png", Name = "C#", Desc = "", Order = 10, Type = skilltype });
            skills.Add(new Skill { Image = "visual-studio.png", Name = "Visual Studio", Desc = "", Order = 20, Type = skilltype });
            skills.Add(new Skill { Image = "ms-sql-server.png", Name = "MS SQL Server", Desc = "", Order = 30, Type = skilltype });
            skills.Add(new Skill { Image = "Adobe_ColdFusion.png", Name = "Abode coldfusion", Desc = "", Order = 40, Type = skilltype });
            skills.Add(new Skill { Image = "ms-iis.png", Name = "icrosoaft IIS", Desc = "", Order = 50, Type = skilltype });
            skills.Add(new Skill { Image = "html-5.png", Name = "HTML 5", Desc = "", Order = 60, Type = skilltype });
            skills.Add(new Skill { Image = "javascript.png", Name = "Javscript/Ecmascript ", Desc = "", Order = 70, Type = skilltype });
            skills.Add(new Skill { Image = "jquery.png", Name = "Jquery", Desc = "", Order = 80, Type = skilltype });
            skills.Add(new Skill { Image = "css3.png", Name = "CSS 3", Desc = "", Order = 90, Type = skilltype });
            skills.Add(new Skill { Image = "bootstrap.png", Name = "Twitter Bootstrap", Desc = "", Order = 90, Type = skilltype });
            skills.Add(new Skill { Image = "dreamweaver.png", Name = "Adobe Dreamweaver", Desc = "", Order = 100, Type = skilltype });
            skills.Add(new Skill { Image = "photoshop.png", Name = "Adobe Photoshop", Desc = "", Order = 110, Type = skilltype });
            skills.Add(new Skill { Image = "mongodb.png", Name = "Mongo db", Desc = "", Order = 110, Type = skilltype });

            skills.Add(new Skill { Image = "dotnet.png", Name = "Microsoft .NET", Desc = "", Order = 15, Type = skilltype });

            skills.Add(new Skill { Image = "ms-sql-server.png", Name = "Microsoft SQL Server", Desc = "", Order = 15, Type = "Server", Home = true });




            foreach (var skill in skills)
            {
                mongodb.Create("Skills", skill);
            }

        }

    }
}
