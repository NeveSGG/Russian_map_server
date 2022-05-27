using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_map_server
{
    public class JSONModel
    {
        [Newtonsoft.Json.JsonArray]
        public class Rootobject
        {

            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public Coords coords { get; set; }
            public string district { get; set; }
            public string name { get; set; }
            public int population { get; set; }
            public string subject { get; set; }
        }

        public class Coords
        {
            public string lat { get; set; }
            public string lon { get; set; }
        }

    }
}
