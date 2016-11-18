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
            List<Client> clientFromData = new ClientDatabase().GetAllClient().ToList<Client>(); 
            ObservableCollection <Client> clients = new ObservableCollection<Client>();


            foreach (Client c in clientFromData)
            {
                clients.Add(c);
            }
            ClientList.ItemsSource = clients;

        }
    }
}
