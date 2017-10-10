using DataBaseApi;
using DataBaseApi.Api.LibraryFiles_DAO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApi
{
    public class PersonDAO_JSON_L : PersonDAO_Files
    {

        public PersonDAO_JSON_L() : base(@"JSONL_DB.txt")
        {
        }

        protected override List<Person> Load()
        {
            if (File.Exists(path) == false)
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            string jsonString = File.ReadAllText(path);
            List<Person> persons = new List<Person>();
            if (jsonString.Length == 0)
                persons = new List<Person>();
            else
                persons = JsonConvert.DeserializeObject<List<Person>>(jsonString);
            return persons;
        }

        protected override void Write(List<Person> persons)
        {
            string jsonString = JsonConvert.SerializeObject(persons);
            File.WriteAllText(path, jsonString);
        }
    }
}