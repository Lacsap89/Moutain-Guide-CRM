using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Moutain_Guide_CRM.Models;
using System.Collections.ObjectModel;
using Moutain_Guide_CRM.Data;

namespace Moutain_Guide_CRM
{
    public partial class ViewClientFromDB : ContentPage
    {
        public ViewClientFromDB()
        {
            
            InitializeComponent();
            fillDatabase();
            List<Client> clientFromData = new ClientDatabase().GetAllClient().ToList<Client>(); 
            ObservableCollection <Client> clients = new ObservableCollection<Client>();


            foreach (Client c in clientFromData)
            {
                clients.Add(c);
            }
            ClientList.ItemsSource = clients;

        }

        public void fillDatabase()
        {
            //new ClientDatabase().DeleteAll();
            int numClient = new ClientDatabase().GetAllClient().Count<Client>();
            if (numClient <= 0)
            {
                Client[] tabClient = new Client[3];
                tabClient[0] = new Client("Nico", "Tschaner", "");
                tabClient[1] = new Client("Maximilien", "Borgeat", "Bon Grimpeur");
                tabClient[2] = new Client("Pascal", "Déléze", "");

                for (int i = 0; i < tabClient.Length; i++)
                {
                    new ClientDatabase().SaveClient(tabClient[i]);
                }
            }
           

        }
    }
}
