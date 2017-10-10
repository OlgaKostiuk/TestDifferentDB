using DataBaseApi.Api.LibraryFiles_DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApi
{
    public class PersonDAO_CSV : PersonDAO_Files
    {
        public PersonDAO_CSV() : base(@"E:\C# 1708\DataBase\DataBaseApi\DataBase\Persons.csv")
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
            string[] lines = File.ReadAllLines(path);
            for (int i = 1; i < lines.Length; i++)
            {
                people.Add(FromCSV(lines[i]));
            }
            return people;
        }


        protected override void Write(List<Person> people)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine("Id, Fn, Ln, Age");
            foreach (Person person in people)
            {
                file.WriteLine(ToCSV(person));
            }
            file.Close();
        }
       

        private string ToCSV(Person person)
        {
            string str = "";
            str += person.Id + ", ";
            str += person.FirstName + ", ";
            str += person.LastName + ", ";
            str += person.Age;
            return str;
        }

        private Person FromCSV(string csv_string)
        {
            Person person = new Person();
            string[] args = csv_string.Split(',');
            person.Id = Int32.Parse(args[0].Trim());
            person.FirstName = args[1].Trim();
            person.LastName = args[2].Trim();
            person.Age = Int32.Parse(args[3].Trim());
            return person;
        }
    }
}
