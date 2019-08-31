using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace People.Library
{
    public class PersonRepository
    {
        WebClient client = new WebClient();
        string baseUri = "http://localhost:9874/";

        public Person[] GetPeople()
        {
            var address = $"{baseUri}api/people";
            string reply = client.DownloadString(address);
            return JsonConvert.DeserializeObject<Person[]>(reply);
        }

        public Person GetPerson(int id)
        {
            var address = $"{baseUri}api/people/{id}";
            string reply = client.DownloadString(address);
            return JsonConvert.DeserializeObject<Person>(reply);
        }
    }
}
