using Sports.Models.Page1;
using Sports.Models.Page1_1;
using Sports.Models.Page2;
using Sports.Models.Page3;
using Sports.Models.Page4;
using Sports.Models.Page5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Sports.Models.Page3;
using TeamDetailList = Sports.Models.Page3.TeamDetailList;

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
        public TeamDetailList GetAllTeamInLeague(int id, int size)
        {
            var httpResponse = client.GetAsync($"api/v1/json/1/lookup_all_teams.php?id={id}").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode) { return null; }

            TeamDetailList result = new TeamDetailList();
            TeamDetailInputList resultService = new TeamDetailInputList();

            using (HttpContent content = httpResponse.Content)
            {
                string stringContent = content.ReadAsStringAsync().Result;
                resultService = JsonSerializer.Deserialize<TeamDetailInputList>(stringContent);
            }

            result.Teams = resultService.teams.Take(size).Select(x => new TeamDetail() { Id = x.idTeam, Name = x.strTeam }).ToList();
            return result;
        }
        public TeamConnectionList GetTeamConnection(int id)
        {
            var httpResponse = client.GetAsync($"api/v1/json/1/lookupteam.php?id={id}").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode) { return null; }

            TeamConnectionList result = new TeamConnectionList();
            TeamConnectionInputList resultService = new TeamConnectionInputList();

            using (HttpContent content = httpResponse.Content)
            {
                string stringContent = content.ReadAsStringAsync().Result;
                resultService = JsonSerializer.Deserialize<TeamConnectionInputList>(stringContent);
            }

            result.Team = resultService.teams.Select(x => new TeamConnection() { Id = x.idTeam, Team_Name = x.strTeam, Facebook = x.strFacebook, Instagram = x.strInstagram }).ToList();
            return result;
        }
        public OutPutLists GetCoutries()
        {
            var httpresponce = client.GetAsync("/api/v1/json/1/all_countries.php").Result;
            httpresponce.EnsureSuccessStatusCode();
            if (!httpresponce.IsSuccessStatusCode)
            {
                return null;
            }
            ServiseLists service;
            HttpContent content = httpresponce.Content;
            var stringcontent = content.ReadAsStringAsync().Result;
            service = JsonSerializer.Deserialize<ServiseLists>(stringcontent);
            OutPutLists outPutLists = new OutPutLists();
            outPutLists.Countries = service.countries.Select(x => new Outputs() { Country_Name = x.name_en }).ToList();
            return outPutLists;

        }
        public string GetId()
        {
            var httpresponce = client.GetAsync($"/api/v1/json/1/searchteams.php?t={Users.MyTeam}").Result;
            httpresponce.EnsureSuccessStatusCode();
            if (!httpresponce.IsSuccessStatusCode)
            {
                return null;
            }
            TmList team;
            HttpContent content = httpresponce.Content;
            var stringcontent = content.ReadAsStringAsync().Result;
            team = JsonSerializer.Deserialize<TmList>(stringcontent);
            var Id = team.teams.Select(x => x.idTeam).ToList();
            return Id[0];
        }
        public OutPutTeamList GetNextEvents(string id)
        {
            var httpresponce = client.GetAsync($"/api/v1/json/1/eventsnext.php?id={id}").Result;
            httpresponce.EnsureSuccessStatusCode();
            if (!httpresponce.IsSuccessStatusCode)
            {
                return null;
            }
            ServiseTeamList service;
            HttpContent content = httpresponce.Content;
            var stringcontent = content.ReadAsStringAsync().Result;
            service = JsonSerializer.Deserialize<ServiseTeamList>(stringcontent);
            OutPutTeamList outPut = new OutPutTeamList();
            outPut.Events = service.events.Select(x => new OutPutTeam() { AwayTeam = x.strAwayTeam, Event_Name = x.strEvent, HomeTeam = x.strHomeTeam, Id = x.idEvent }).ToList();
            return outPut;
        }
        public LastEventOutPutList GetLastEvents(string id)
        {
            var httpresponce = client.GetAsync($"/api/v1/json/1/eventslast.php?id={ id}").Result;
            httpresponce.EnsureSuccessStatusCode();
            if (!httpresponce.IsSuccessStatusCode)
            {
                return null;
            }
            LastEventServiseList service;
            HttpContent content = httpresponce.Content;
            var stringcontent = content.ReadAsStringAsync().Result;
            service = JsonSerializer.Deserialize<LastEventServiseList>(stringcontent);
            LastEventOutPutList outPut = new LastEventOutPutList();
            outPut.Events = service.results.Select(x => new LastEventOutPut() { AwayTeam = x.strAwayTeam, Event_Name = x.strEvent, HomeTeam = x.strHomeTeam, Id = x.idEvent, Away_Score = x.intAwayScore ,Home_Score = x.intHomeScore}).ToList();
            return outPut;
        }


    }
}
