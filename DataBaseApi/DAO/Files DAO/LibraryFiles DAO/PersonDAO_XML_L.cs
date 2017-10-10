using DataBaseApi;
using DataBaseApi.Api.LibraryFiles_DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DataBaseApi
{
    public class PersonDAO_XML_L : PersonDAO_Files
    {
        public PersonDAO_XML_L() : base(@"XMLL_DB.txt")
        {
        }

        protected override List<Person> Load()
        {
            if (File.Exists(path) == false)
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            TextReader reader = File.OpenText(path);
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            List<Person> persons;
            try
            {
                persons = (List<Person>)serializer.Deserialize(reader);
            }
            catch (Exception exception)
            {
                persons = new List<Person>();
            }
            reader.Close();
            return persons;
        }

        protected override void Write(List<Person> persons)
        {
            TextWriter writer = File.CreateText(path);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            serializer.Serialize(writer, persons);
            writer.Close();
        }

    }
}