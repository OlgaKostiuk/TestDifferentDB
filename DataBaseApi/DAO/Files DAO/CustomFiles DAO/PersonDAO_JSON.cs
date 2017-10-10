using DataBaseApi.Api.LibraryFiles_DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApi
{
    public class PersonDAO_JSON : PersonDAO_Files
    {
        public PersonDAO_JSON() : base(@"E:\C# 1708\DataBase\DataBaseApi\DataBase\Persons.json")
        {
        }
      
        protected override List<Person> Load()
        {
            List<Person> people = new List<Person>();
            if (File.Exists(path) == false)
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            string line = File.ReadAllText(path);
            if (line.Length != 0)
            {
                line = (line.Remove(0, line.IndexOf('[') + 1));
                line = line.Remove(line.Length - 2, 2);
            }
            int i = 0;
            while (i < line.Length)
            {
                string str = "";
                while (line.ElementAt(i) != '}')
                {
                    str += line.ElementAt(i++);
                }
                str += line.ElementAt(i++);
                i++;
                people.Add(FromJSON(str));
            }
            return people;

        }


        protected override void Write(List<Person> people)
        {
            StreamWriter file = new StreamWriter(path);
            file.Write("{ Persons : [");
            for (int i = 0; i < people.Count; i++)
            {
                file.Write(ToJSON(people.ElementAt(i)) + ((i != (people.Count - 1)) ? "," : ""));
            }
            file.Write("]}");
            file.Close();
        }


        private string ToJSON(Person person)
        {
            string str = "{";
            str += $"Id: {person.Id},";
            str += $"FirstName: {person.FirstName},";
            str += $"LastName: {person.LastName},";
            str += $"Age: {person.Age}";
            str += "}";
            return str;
        }
        private Person FromJSON(string json_string)
        {
            Person person = new Person();
            string[] args = json_string.Split(':', ',', '}');
            person.Id = Int32.Parse(args[1].Trim());
            person.FirstName = args[3].Trim();
            person.LastName = args[5].Trim();
            person.Age = Int32.Parse(args[7].Trim());
            return person;
        }

    }
}
