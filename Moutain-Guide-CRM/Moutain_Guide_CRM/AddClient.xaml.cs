using System;
using Moutain_Guide_CRM.Models;
using Xamarin.Forms;
using Moutain_Guide_CRM.Data;
using Android.App;
using Android.Content;
using LocalNotifications.Plugin.Abstractions;
using LocalNotifications.Plugin;

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

            var notifier = CrossLocalNotifications.CreateLocalNotifier();
            var notification = new LocalNotification
            {
                Text = "Client " +client.Firstname + " added to the database",
                Title = "New local Client",
                Id = 2,
                NotifyTime = DateTime.Now
            };
            notifier.Notify(notification);
        }
    }
}
