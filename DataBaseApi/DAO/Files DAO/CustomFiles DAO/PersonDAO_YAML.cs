using DataBaseApi.Api.LibraryFiles_DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApi
{
    public class PersonDAO_YAML : PersonDAO_Files
    {
        public PersonDAO_YAML() : base(@"E:\C# 1708\DataBase\DataBaseApi\DataBase\Persons.yaml")
        {
        }

        protected override List<Person> Load()
        {
            List<Person> people = new List<Person>();
            FileStream fs;
            if (File.Exists(path) == false)
            {
                fs = File.Create(path);
                fs.Close();
            }
            string[] lines = File.ReadAllLines(path);
            string[] YAMLlines = new string[(lines.Length - 1) / 4];
            for (int i = 1, k = 1; i < lines.Length; i++)
            {
                if (i != 4 * k + 1)
                    YAMLlines[k - 1] += lines[i] + "\n";
                else
                    YAMLlines[++k - 1] += lines[i] + "\n";
            }
            foreach (string str in YAMLlines)
            {
                people.Add(FromYAML(str));
            }
            return people;

        }

        protected override void Write(List<Person> people)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine("Persons:");
            foreach (Person person in people)
            {
                file.WriteLine(ToYAML(person));
            }
            file.Close();
        }


        private string ToYAML(Person person)
        {
            string str = "";
            str += $"- Id: {person.Id}";
            str += $"\nFirstName: {person.FirstName}";
            str += $"\nLastName: {person.LastName}";
            str += $"\nAge: {person.Age}";
            return str;
        }
        private Person FromYAML(string yaml_string)
        {
            Person person = new Person();
            string[] args = yaml_string.Split('\n', ':', '-');
            person.Id = Int32.Parse(args[2].Trim());
            person.FirstName = args[4].Trim();
            person.LastName = args[6].Trim();
            person.Age = Int32.Parse(args[8].Trim());
            return person;
        }

    }
}
