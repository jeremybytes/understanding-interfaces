using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace PersonRepository.CSV
{
    public class CSVRepository : IPersonRepository
    {
        string path;

        public CSVRepository()
        {
            var filename = ConfigurationManager.AppSettings["CSVFileName"];
            path = AppDomain.CurrentDomain.BaseDirectory + filename;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>();

            if (File.Exists(path))
            {
                using (var sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var elems = line.Split(',');
                        var per = new Person()
                        {
                            Id = Int32.Parse(elems[0]),
                            GivenName = elems[1],
                            FamilyName = elems[2],
                            StartDate = DateTime.Parse(elems[3]),
                            Rating = Int32.Parse(elems[4]),
                            FormatString = elems[5],
                        };
                        people.Add(per);
                    }
                }
            }
            return people;
        }

        public Person GetPerson(int id)
        {
            Person selPerson = new Person();
            if (File.Exists(path))
            {
                var sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var elems = line.Split(',');
                    if (Int32.Parse(elems[0]) == id)
                    {
                        selPerson.Id = Int32.Parse(elems[0]);
                        selPerson.GivenName = elems[1];
                        selPerson.FamilyName = elems[2];
                        selPerson.StartDate = DateTime.Parse(elems[3]);
                        selPerson.Rating = Int32.Parse(elems[4]);
                        selPerson.FormatString = elems[5];
                    }
                }
            }

            return selPerson;
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
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
    }
}
