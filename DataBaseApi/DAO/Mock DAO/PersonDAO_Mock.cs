using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApi
{
    class PersonDAO_Mock : IPersonDAO
    {
        SortedDictionary<int, Person> people = null;

        public PersonDAO_Mock()
        {
            people = new SortedDictionary<int, Person>();
            Person person = new Person(1, "Tom", "Test", 25);
            people.Add(person.Id, person);
            person = new Person(2, "Bob", "Smith", 22);
            people.Add(person.Id, person);
            person = new Person(10, "Vasya", "Ivanov", 121);
            people.Add(person.Id, person);
        }

        public void Create(Person p)
        {
            people.Add(p.Id, p);
        }

        public void Delete(Person p)
        {
            people.Remove(p.Id);
        }

        public List<Person> Read()
        {
            return people.Values.ToList();
        }

        public void Update(Person p)
        {
            people[p.Id] = p;
        }
    }
}
