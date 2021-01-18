using Sports.Models.Page1;
using Sports.Models.Page2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
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

        public OutputList Get_Leagues(string country, int size)
        {
             var httpresponce = client.GetAsync($"/api/v1/json/1/search_all_leagues.php?c={country}&s={Users.Mysport}").Result;
             httpresponce.EnsureSuccessStatusCode();
             if (!httpresponce.IsSuccessStatusCode)
                 return null;
             ServiceList service;
             OutputList output = new OutputList();
             using (HttpContent content = httpresponce.Content)
             {
                  string stringcontent = content.ReadAsStringAsync().Result;
                  service = JsonSerializer.Deserialize<ServiceList>(stringcontent);
             }
             var take = service.countrys.Take(size);
             var outputlist = take.Select(s => new OutPut() { Current_Season = s.strCurrentSeason, created_year = s.intFormedYear, FirstEvent = s.dateFirstEvent, id = s.idLeague, name = s.strLeague }).ToList();
             output.Leagues = outputlist;
             return output;
          
           
        }
    }
}
