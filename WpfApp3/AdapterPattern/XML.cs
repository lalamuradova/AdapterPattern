using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfApp3.AdapterPattern
{  
  public  class XML
    {  
            public void Serializer(string name,string surname,string email)
            {  
                using (var writer = new XmlTextWriter($"Login{name}.xml", Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Logins");

                    
                        writer.WriteStartElement("Login");

                        
                        writer.WriteAttributeString("Name: ", name);
                        writer.WriteAttributeString("Surname: ", surname);
                        writer.WriteAttributeString("Email: ", email);

                    writer.WriteEndElement();
                   

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }         
            
             

  }
}
