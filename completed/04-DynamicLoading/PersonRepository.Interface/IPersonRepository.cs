using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRepository.Interface
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson(int id);

        void AddPerson(Person newPerson);

        void UpdatePerson(int id, Person updatedPerson);

        void DeletePerson(int id);

        void UpdatePeople(IEnumerable<Person> updatedPeople);
    }
}
