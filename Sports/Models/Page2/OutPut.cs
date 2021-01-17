using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Models.Page2
{
    public class OutPut
    {
        public string id{ get; set; }
        public string name { get; set; }
        public string created_year { get; set; }
        public string FirstEvent { get; set; }
        public string Current_Season { get; set; }
    }
    public class OutputList
    {
       public List<OutPut> Leagues { get; set; }
       
    }
}
