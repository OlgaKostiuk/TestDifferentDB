using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseApi.Api.LibraryFiles_DAO;
using System.IO;

namespace DataBaseApi
{
    public class PersonDAO_Binary : PersonDAO_Files
    {
        public PersonDAO_Binary() : base("Binary.txt")
        {
        }

        protected override List<Person> Load()
        {
            List<Person> li = new List<Person>();
            FileStream sr = new FileStream(path, FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(sr);
            while(br.BaseStream.Position != br.BaseStream.Length)
            {
                Person p = new Person();
                p.Id = br.ReadInt32();
                br.ReadString();//'\n'
                p.FirstName=br.ReadString();
                br.ReadString();//'\n'
                p.LastName = br.ReadString();
                br.ReadString();//'\n'
                p.Age = br.ReadInt32();
                br.ReadString();//'\n'
                li.Add(p);
            }
            sr.Close();
            return li;
        }

        protected override void Write(List<Person> people)
        {
            FileStream sw = new FileStream(path,FileMode.Create);
            BinaryWriter bw = new BinaryWriter(sw);
            foreach(Person p in people)
            {
                bw.Write(p.Id);
                bw.Write("\n");
                bw.Write(p.FirstName);
                bw.Write("\n");
                bw.Write(p.LastName);
                bw.Write("\n");
                bw.Write(p.Age);
                bw.Write("\n");
            }
            sw.Close();
        }
    }
}
