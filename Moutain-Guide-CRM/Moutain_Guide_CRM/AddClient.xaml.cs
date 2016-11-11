using System;
using Moutain_Guide_CRM.Models;

using Xamarin.Forms;
using Moutain_Guide_CRM.Data;

namespace Moutain_Guide_CRM
{
    public partial class AddClient : ContentPage
    {
        public AddClient()
        {
            InitializeComponent();
            this.Title = "Add a new client";
            addClientBtn.Clicked += AddClientBtn_Clicked;
        }

        private void AddClientBtn_Clicked(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Firstname = FirstnameLabel.Text;
            client.Lastname = LastnameLabel.Text;
            client.Comment = CommentLabel.Text;

            new ClientDatabase().SaveClient(client);

            addClientBtn.Text = "Client added to the database";
           


        }
    }
}
