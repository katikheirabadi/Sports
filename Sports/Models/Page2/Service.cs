using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Models.Page2
{
    public class Service
    {
      public string idLeague { get; set; }
      public string idSoccerXML { get; set; }
      public string idAPIfootball { get; set; }
      public string strSport { get; set; }
      public string strLeague { get; set; }
      public string strLeagueAlternate { get; set; }
      public string strDivision { get; set; }
      public string idCup { get; set; }
      public string strCurrentSeason { get; set; }
      public string intFormedYear { get; set; }
      public string dateFirstEvent { get; set; }
      public string strGender { get; set; }
      public string strCountry { get; set; }
      public string strWebsite { get; set; }
      public string strFacebook { get; set; }
      public string strTwitter { get; set; }
      public string strYoutube { get; set; }
      public string strRSS { get; set; }
      public string strDescriptionEN { get; set; }
      public string strDescriptionDE { get; set; }
      public string strDescriptionFR { get; set; }
      public string strDescriptionIT { get; set; }
      public string strDescriptionCN { get; set; }
      public string strDescriptionJP { get; set; }
      public string strDescriptionRU { get; set; }
      public string strDescriptionES { get; set; }
      public string strDescriptionPT { get; set; }
      public string strDescriptionSE { get; set; }
      public string strDescriptionNL { get; set; }
      public string strDescriptionHU { get; set; }
      public string strDescriptionNO { get; set; }
      public string strDescriptionPL { get; set; }
      public string strDescriptionIL { get; set; }
      public string strFanart1 { get; set; }
      public string strFanart2 { get; set; }
      public string strFanart3 { get; set; }
      public string strFanart4 { get; set; }
      public string strBanner { get; set; }
      public string strBadge { get; set; }
      public string strLogo { get; set; }
      public string strPoster { get; set; }
      public string strTrophy { get; set; }
      public string strNaming { get; set; }
      public string strComplete { get; set; }
      public string strLocked { get; set; }

    }
    public class ServiceList
    {
        public List<Service> countrys { get; set; }
    }
}
