using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.AdapterPattern
{
  public  class Json
    {
      public void JsonSerialization(string name,string surname,string email)
        {
            string login = $"Name: {name} Surname: {surname} Email: {email}";

            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("Login.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, login);
                }
            }
        }
    }
}
