using Microsoft.EntityFrameworkCore;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonRepository.SQL
{
    public class SQLRepository : IPersonRepository
    {
        DbContextOptions<PersonContext> options;

        public SQLRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersonContext>();
            optionsBuilder.UseSqlite("Data Source=People.db");
            options = optionsBuilder.Options;
        }

        public IEnumerable<Person> GetPeople()
        {
            using (var context = new PersonContext(options))
            {
                return context.People.ToListAsync().Result;
            }
        } 

        public Person GetPerson(int id)
        {
            using (var context = new PersonContext(options))
            {
                return context.People.Where(p => p.Id == id).FirstOrDefault();
            }
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
