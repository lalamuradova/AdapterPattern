using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.AdapterPattern
{
    class Controller
    {
        private readonly Converter _converter;
        public Controller(IAdapter adapter)
        {
            _converter = new Converter(adapter);
        }
        public void Start(string name, string surname, string email)
        {
            _converter.Serializer(name, surname, email);
        }
    }
}
