using DataBaseApi.Api.LibraryFiles_DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApi
{
    public class PersonDAO_XML : PersonDAO_Files
    {

        public PersonDAO_XML() : base(@"E:\C# 1708\DataBase\DataBaseApi\DataBase\Persons.xml")
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
            string[] XMLlines = new string[(lines.Length - 2) / 6];
            for (int i = 1, k = 0; i < lines.Length - 1; i++)
            {
                if (lines[i] == "\t</Person>")
                    k++;
                else if (lines[i] != "\t<Person>")
                    XMLlines[k] += lines[i];
            }
            foreach (string line in XMLlines)
            {
                people.Add(FromXML(line));
            }
            return people;

        }
   

        protected override void Write(List<Person> people)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine("<Persons>");
            foreach (Person person in people)
            {
                file.WriteLine(ToXML(person));
            }
            file.WriteLine("</Persons>");
            file.Close();

        }

        private string ToXML(Person person)
        {
            string str = "\t<Person>\n";
            str += $"\t\t<Id>{person.Id}</Id>\n";
            str += $"\t\t<FirstName>{person.FirstName}</FirstName>\n";
            str += $"\t\t<LastName>{person.LastName}</LastName>\n";
            str += $"\t\t<Age>{person.Age}</Age>\n";
            str += "\t</Person>";
            return str;
        }
        private Person FromXML(string str)
        {
            Person person = new Person();
            str = str.Replace("\t", "");
            string[] args = str.Split('<', '>');
            person.Id = Int32.Parse(args[2]);
            person.FirstName = args[6];
            person.LastName = args[10];
            person.Age = Int32.Parse(args[14]);
            return person;
        }

    }
}
