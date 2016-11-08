﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
//Petit test
namespace Moutain_Guide_CRM
{
    public partial class ViewClient:ContentPage
    {
        public ViewClient()
        {
            InitializeComponent();
            this.Title = "Mountain Guide CRM";
            getClientBtn.Clicked += GetClientBtn_Clicked;

            this.BindingContext = new Client();
        }

        private void GetClientBtn_Clicked(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Firstname = "Pascal";
            client.Lastname = "Deleze";
            client.Comment = "Test";
            getClientBtn.Text = client.Firstname;
            FirstnameLabel.Text = client.Firstname;
            LastnameLabel.Text = client.Lastname;
            CommentLabel.Text = client.Comment;


        }
    }
}