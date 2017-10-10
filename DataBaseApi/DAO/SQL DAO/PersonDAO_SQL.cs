using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApi.Api.LibraryFiles_DAO
{
    abstract public class PersonDAO_SQL : IPersonDAO
    {
        protected string tableName = "";

        public PersonDAO_SQL()
        {
            tableName = "person";
        }

        public void Create(Person person)
        {
            OpenConnection();
            string cmd =
                $"INSERT INTO {tableName} (Id, FirstName, LastName, Age) " +
                $"VALUES ({person.Id}, '{person.FirstName}', '{person.LastName}', {person.Age})";
            ExecuteCommand(cmd);
            CloseConnection();
        }

        public void Delete(Person person)
        {
            OpenConnection();
            string cmd =
                $"Delete FROM {tableName} " +
                $"WHERE Id = {person.Id};";
            ExecuteCommand(cmd);
            CloseConnection();
        }

        public List<Person> Read()
        {            
            OpenConnection();
            string cmd = $"SELECT * FROM {tableName};";
            List<Person> listPerson = ReadData(cmd);
            CloseConnection();
            return listPerson;
        }

        public void Update(Person person)
        {
            OpenConnection();
            string cmd =
                $"UPDATE {tableName} " +
                $"SET FirstName = '{person.FirstName}', LastName='{person.LastName}', Age={person.Age} " +
                $"WHERE Id = {person.Id};";
            ExecuteCommand(cmd);
            CloseConnection();
        }

        abstract protected void CloseConnection();
        abstract protected void OpenConnection();
        abstract protected void ExecuteCommand(string cmd);
        abstract protected List<Person> ReadData(string cmd);

    }
}
