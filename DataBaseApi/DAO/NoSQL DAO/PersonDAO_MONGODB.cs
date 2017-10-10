using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApi
{
    class PersonDAO_MONGODB : IPersonDAO
    {
        IMongoCollection<Person> collection = null;
        public PersonDAO_MONGODB()
        {
            string strConn = @"mongodb://localhost:27017";

            MongoClient client = new MongoClient(strConn);
            IMongoDatabase database = client.GetDatabase("mongoPerson");          
            collection = database.GetCollection<Person>("people");
        }

        public void Create(Person person)
        {
            if (collection.Find(x => x.Id == person.Id).ToList().Count == 0)
            {
                collection.InsertOne(person);
            }
        }

        public void Delete(Person person)
        {
            collection.DeleteOne(x => x.Id == person.Id);
        }

        public List<Person> Read()
        {
            List<Person> listPerson = new List<Person>();
            listPerson = collection.Find(x => true).ToList();
            listPerson.Sort(Person.CompareById);
            return listPerson;
        }

        public void Update(Person person)
        {           
            collection.ReplaceOne(x => x.Id == person.Id, person);
        }
    }
}
