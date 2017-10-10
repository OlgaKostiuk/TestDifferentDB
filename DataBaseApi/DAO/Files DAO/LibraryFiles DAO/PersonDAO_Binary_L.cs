using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using DataBaseApi;
using DataBaseApi.Api.LibraryFiles_DAO;
namespace DataBaseApi
{
    public class PersonDAO_Binary_L : PersonDAO_Files
    {
        public PersonDAO_Binary_L() : base("BinaryL_DB.txt")
        {
        }
        protected override List<Person> Load()
        {
            List<Person> persons = new List<Person>();
            if (File.Exists(path) == false)
            {
                return persons;
            }
            else
            {
                string[] ls = File.ReadAllLines(path);
                if (ls.Length == 0)
                    return persons;
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                persons = (List<Person>)bf.Deserialize(fs);
            }
            return persons;
        }

        protected override void Write(List<Person> persons)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, persons);
            }
        }
    }
}
