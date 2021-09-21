using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.AdapterPattern
{
    class XMLAdapter : IAdapter
    {
        private XML _db;

        public XMLAdapter(XML db)
        {
            _db = db;
        }


        public void Serializer(string name, string surname, string email)
        {
            _db.Serializer(name, surname, email);
        }
    }

}
    
