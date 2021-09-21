using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.AdapterPattern
{
    interface IAdapter
    {
            void Add();
            void Update();
            string Get(int id);
        
    }



}
