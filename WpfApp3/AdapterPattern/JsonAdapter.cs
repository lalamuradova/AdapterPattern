using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.AdapterPattern
{
    class JsonAdapter : IAdapter
    {
        private Json _db;

        public JsonAdapter(Json db)
        {
            _db = db;
        }
        public void Serializer(string name, string surname, string email)
        {
            _db.JsonSerialization(name, surname, email);
        }
    }
}
