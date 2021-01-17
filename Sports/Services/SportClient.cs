using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sports.Services
{
    public class SportClient
    {
        private readonly HttpClient client;
        private const string BaseAdress = "https://www.thesportsdb.com";

        public SportClient(HttpClient client)
        {
            this.client = client;
            this.client.BaseAddress = new Uri(BaseAdress);
            this.client.DefaultRequestHeaders.Add("Accept", "application/json");

        }
    }
}
