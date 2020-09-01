using MongoCrud;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.MongoDBConsole
{
    public class TestimonialCrud
    {
        private MongoCrud.DataAccess mongodb;
        public TestimonialCrud(IDatabaseSettings databaseSettings)
        {
            mongodb = new MongoCrud.DataAccess(databaseSettings);

        }

        public void Insert()
        {
            List<Testimonial> testimonials = new List<Testimonial>();



            //skills.Add(new Skill { Image = "c-sharp.png", Name = "C#", Desc = "", Order=10, Type = skilltype });
            //skills.Add(new Skill { Image = "visual-studio.png", Name = "Visual Studio", Desc = "", Order = 20, Type = skilltype });
            //skills.Add(new Skill { Image = "ms-sql-server.png", Name = "MS SQL Server", Desc = "",  Order = 30, Type = skilltype });
            //skills.Add(new Skill { Image = "Adobe_ColdFusion.png", Name = "Abode coldfusion", Desc = "", Order = 40, Type = skilltype });
            //skills.Add(new Skill { Image = "ms-iis.png", Name = "icrosoaft IIS", Desc = "", Order = 50, Type = skilltype });
            //skills.Add(new Skill { Image = "html-5.png", Name = "HTML 5", Desc = "", Order = 60, Type = skilltype });
            //skills.Add(new Skill { Image = "javascript.png", Name = "Javscript/Ecmascript ", Desc = "", Order = 70, Type = skilltype });
            //skills.Add(new Skill { Image = "jquery.png", Name = "Jquery", Desc = "", Order = 80, Type = skilltype });
            //skills.Add(new Skill { Image = "css3.png", Name = "CSS 3", Desc = "", Order = 90, Type = skilltype });
            //skills.Add(new Skill { Image = "bootstrap.png", Name = "Twitter Bootstrap", Desc = "",  Order = 90, Type = skilltype });
            //skills.Add(new Skill { Image = "dreamweaver.png", Name = "Adobe Dreamweaver", Desc = "", Order = 100, Type = skilltype });
            //skills.Add(new Skill { Image = "photoshop.png", Name = "Adobe Photoshop", Desc = "", Order = 110, Type = skilltype });
            //skills.Add(new Skill { Image = "mongodb.png", Name = "Mongo db", Desc = "", Order = 110, Type = skilltype });

            testimonials.Add(new Testimonial { Image = "graham-bond.jpg", Author = "Graham Bond",  Recommendation= "I had the good fortune to work with Barry for more than fifteen years. During this time he never stopped adding to his many skills and utilising them to create innovative digital business solutions. Barry is one of the few developers I encountered that can see the whole picture; a great asset.", Position="Managing Directory Hemming Group Ltd (retired)" });


            testimonials.Add(new Testimonial { Image = "laura-sharman.jpg", Author = "Laura Sharman", Recommendation = "Having worked closely with Barry for a number of years, I can't recommend him highly enough. He is extremely creative and innovative, and was always looking for new ways to improve how we delivered digital services.he took a lot of time to understand exactly what I needed to do my job effectively and would constantly be suggesting ideas that would save me time on a day-to - day basis and deliver a better experience for our readers and advertisers.He also genuinely cared about the work he was doing and this showed in his commitment to the job. On a personal level, I really enjoyed working with Barry and knew that he would instantly help resolve business critical issues.He would also explain problems and solutions in a straight forward manner that I would be able to understand", Position = "Editor at Localgov.co.uk" });


            testimonials.Add(new Testimonial { Image = "lotte-debell.jpg", Author = "Lotte Debell", Recommendation = "I worked with Barry for ten years and he was a pleasure to work with. We collaborated on several website projects and he was knowledgeable, patient, and generous with his time. He was also always open to exploring new ways of doing things, trying out new technologies, and finding creative solutions to problems. And if some of our ideas were not possible, he would take the time to explain why and offer alternative suggestions. He managed to make the often stressful process of launching digital projects fun.", Position = "Writer/Editor " });


            testimonials.Add(new Testimonial { Image = "simon-whatley.jpg", Author = "Simon Whatley", Recommendation = "Barry is a keen and knowledgeable manager, who understands both the business' and developer's needs. His ability to endorse new technologies, makes him a great person with which to work.", Position = "Lead Service Designer and Creative Technologist" });

            testimonials.Add(new Testimonial { Image = "nick-tong.jpg", Author = "Nick Tong", Recommendation = "Barry has a great understanding of all things web. He can take ideas and make them into a viable product which delivers beyond expectation.", Position= "Transformational change CTO" });


            foreach (var item in testimonials)
            {
                mongodb.Create("Testimonials", item);
            }

        }
    }
}
