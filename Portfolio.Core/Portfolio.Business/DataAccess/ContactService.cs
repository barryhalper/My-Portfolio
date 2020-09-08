using MongoCrud;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Business.DataAccess
{
    public class ContactService : IContactService
    {
        private MongoCrud.DataAccess mongoDb;
        //private string database;
        private const string table = "Contact";

        public ContactService(IDatabaseSettings databaseSettings)
        {
            mongoDb = new MongoCrud.DataAccess(databaseSettings);
        }

        public async void CreateAysnc(Contact contact)
        {
            contact.Created = DateTime.Now;
            await mongoDb.CreateAsync<Contact>(table, contact);
        }
    }
}
