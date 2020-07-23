using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModoLabs
{
    class weatherInformation
    {
       


        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }

        }

        public class weather
        {
            public string Base { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double feels_Like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public int visibility { get; set; }

        }
        public class wind
        {
            public double speed { get; set; }
            public int deg { get; set; }
        }
        public class clouds
        {
            public int all { get; set; }
            public int dt { get; set; }
        }
        public class sys
        {
            public int type { get; set; }
            public int id { get; set; }
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }
        public class root {
            public string name { get; set; }
            public sys sys { get; set; }
            public double dt { get; set; }
            public wind wind { get; set; }
            public main main { get; set; }
            public List<weather> weatherList { get; set; }
            public int timezone { get; set; }
            public int id { get; set; }
            public coord coordinate { get; set; }
        }
        


    }
}
