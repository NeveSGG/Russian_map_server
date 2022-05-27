using System;
using System.IO;
using System.Text;
namespace Russian_map_server
{
    class Program
    {

        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "json1.json");
            var json = File.ReadAllText(path);

            var jsonObjs = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<City>>(json);
           using(CitiesContext db=new CitiesContext())
            {
                db.cities.AddRange(jsonObjs);
                db.SaveChanges();
                
           }
        }
    }
}
