using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Moutain_Guide_CRM.Data
{
    //Classe pour créer et gérer la table Client
    class ClientDatabase
    {
        static object locker = new object();

        SQLiteConnection database;

        //Creation de la table client
        public ClientDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Models.Client>();
        }

        //Récupération de tous les client depuis la db
        public IEnumerable<Models.Client> GetAllClient()
        {
            lock (locker)
            {
                return (from i in database.Table<Models.Client>() select i).ToList();
            }
        }

        //Mettre à jour ou enregistrer un nouveau client
        public int SaveClient(Models.Client client)
        {
            lock (locker)
            {
                if (client.Id != 0)
                {
                    database.Update(client);
                    return client.Id;
                }
                else
                {
                    return database.Insert(client);
                }
            }
        }
    }
}
