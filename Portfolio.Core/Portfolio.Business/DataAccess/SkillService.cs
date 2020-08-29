using MongoCrud;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Business.DataAccess
{
    public class SkillService : ISkillService
    {
        private MongoCrud.DataAccess mongoDb;
        //private string database;
        private const string table="Skills";

        public SkillService(IDatabaseSettings databaseSettings)
        {          
            mongoDb = new MongoCrud.DataAccess(databaseSettings);
        }


        public List<Skill> Read(bool forHome)
        {
            return mongoDb.Read<Skill>(table).Where(x=>x.Home==true).OrderBy(x=>x.Order).ToList();
        }


        public List<Skill> Read()
        {
            return mongoDb.Read<Skill>(table);
        }

        //public void Insert()
        //{
        //    List<Skill> skills = new List<Skill>();
        //    skills.Add(new Skill { Image = "c-sharp.png", Name = "C#", Desc = "" });
        //    skills.Add(new Skill { Image = "visual-studio.png", Name = "Visual Studio", Desc = "" });
        //    skills.Add(new Skill { Image = "ms-sql-server.png", Name = "MS SQL Server", Desc = "" });
        //    skills.Add(new Skill { Image = "Adobe_ColdFusion.png", Name = "Abode coldfusion", Desc = "" });
        //    skills.Add(new Skill { Image = "ms-iis.png", Name = "icrosoaft IIS", Desc = "" });
        //    skills.Add(new Skill { Image = "html-5.png", Name = "HTML 5", Desc = "" });
        //    skills.Add(new Skill { Image = "javascript.png", Name = "Javscript/Ecmascript ", Desc = "" });
        //    skills.Add(new Skill { Image = "jquery.png", Name = "Jquery", Desc = "" });
        //    skills.Add(new Skill { Image = "css3.png", Name = "CSS 3", Desc = "" });
        //    skills.Add(new Skill { Image = "bootstrap.png", Name = "Twitter Bootstrap", Desc = "" });
        //    skills.Add(new Skill { Image = "dreamweaver.png", Name = "Adobe Dreamweaver", Desc = "" });
        //    skills.Add(new Skill { Image = "photoshop.png", Name = "Adobe Photoshop", Desc = "" });

        //    foreach (var skill in skills) {
        //        mongoDb.Create(table, skill);
        //    }

        //}

    }
}
