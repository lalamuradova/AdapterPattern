using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Adapter
{
    class Json
    {
        

        class SqlAdapter : IAdapter
        {
            private SqlDb _db;

            public SqlAdapter(SqlDb db)
            {
                _db = db;
            }

            public void Add()
            {
                _db.Add();
            }

            public string Get(int id)
            {
                return _db.Get(id);
            }

            public void Update()
            {
                _db.Update();
            }
        }
        class MangoAdapter : IAdapter
        {
            private MangoDB _db;

            public MangoAdapter(MangoDB db)
            {
                _db = db;
            }

            public void Add()
            {
                _db.InsertToDb();
            }

            public string Get(int id)
            {
                return _db.GetData(id);
            }

            public void Update()
            {
                _db.ChangeDataInDb();
            }
        }

        
        
        class Converter
        {
            private readonly IAdapter _adapter;

            public Converter(IAdapter adapter)
            {
                _adapter = adapter;
            }
            public void Add()
            {
                _adapter.Add();
            }
            public void Update()
            {
                _adapter.Update();
            }

            public string Get(int id)
            {
                return _adapter.Get(id);
            }
        }

        class Application
        {
            private readonly Converter _converter;
            public Application(IAdapter adapter)
            {
                _converter = new Converter(adapter);
            }
            public void Start()
            {
                _converter.Add();
                _converter.Update();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("For MangoDb 1 : ");
                    Console.WriteLine("For SQL 2 : ");
                    int select = int.Parse(Console.ReadLine());
                    IAdapter adapter;
                    if (select == 1)
                    {
                        MangoDB database = new MangoDB();
                        adapter = new MangoAdapter(database);

                    }
                    else
                    {
                        SqlDb database = new SqlDb();
                        adapter = new SqlAdapter(database);
                    }

                    Application application = new Application(adapter);
                    application.Start();
                }
            }
        }

    }
}
