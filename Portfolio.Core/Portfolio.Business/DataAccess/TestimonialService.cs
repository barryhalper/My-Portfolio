using MongoCrud;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.DataAccess
{
    public class TestimonialService : ITestimonialService
    {

        private MongoCrud.DataAccess mongoDb;
        //private string database;
        private const string table = "Testimonials";

        public TestimonialService(IDatabaseSettings databaseSettings)
        {
            mongoDb = new MongoCrud.DataAccess(databaseSettings);
        }

        public List<Testimonial> Read()
        {
            return mongoDb.Read<Testimonial>(table);
        }

    }
}
