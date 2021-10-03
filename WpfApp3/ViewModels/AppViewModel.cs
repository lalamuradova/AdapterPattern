using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp3.Commands;
using System.Windows;
using WpfApp3.AdapterPattern;

namespace WpfApp3.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged(); }
        }


        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand CheckedXmlCommand { get; set; }
        public RelayCommand CheckedJsonCommand { get; set; }
        public bool IsXml { get; set; } = true;
        public AppViewModel()
        {
            SaveCommand = new RelayCommand((sender)=> {

                Controller controller;
                IAdapter adapter;
                if (IsXml)
                {
                    XML xml = new XML();
                    adapter = new XMLAdapter(xml);
                }
                else
                {
                    Json json = new Json();
                    adapter = new JsonAdapter(json);
                  
                }
                    controller = new Controller(adapter);
                    controller.Start(Name, Surname, Email);

               MessageBox.Show("Saved");
            });

            CheckedXmlCommand = new RelayCommand((sender) =>
              {
                  IsXml = true;                  
              });
            CheckedJsonCommand = new RelayCommand((sender) =>
            {
                IsXml = false;
            });

        }
    }
    
}
