using Newtonsoft.Json;
using PersonRepository.Interface;
using System.Collections.Generic;
using System.Net;

namespace PersonRepository.Service
{
    public class ServiceRepository : IPersonRepository
    {
        WebClient client = new WebClient();
        string baseUri = "http://localhost:9874/";

        public IEnumerable<Person> GetPeople()
        {
            var address = $"{baseUri}api/people";
            string reply = client.DownloadString(address);
            return JsonConvert.DeserializeObject<List<Person>>(reply);
        }

        public Person GetPerson(int id)
        {
            var address = $"{baseUri}api/people/{id}";
            string reply = client.DownloadString(address);
            return JsonConvert.DeserializeObject<Person>(reply);
        }

        public void AddPerson(Person newPerson)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new System.NotImplementedException();
        }
    }
}
