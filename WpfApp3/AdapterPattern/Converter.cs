using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.AdapterPattern
{
    class Converter
    {
            private readonly IAdapter _adapter;

            public Converter(IAdapter adapter)
            {
                _adapter = adapter;
            }
            public void Serializer(string name, string surname, string email)
            {
                _adapter.Serializer(name,surname,email);
            }
        
    }
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
