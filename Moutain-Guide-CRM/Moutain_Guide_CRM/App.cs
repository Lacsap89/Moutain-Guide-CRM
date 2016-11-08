using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Moutain_Guide_CRM
{
    public class App : Application
    {
        public App()
        {
            //Xamarin ! Je suis venu pour négocier !       Xamarin ! Je suis venu pour négocier.        Xamarin ! Je suis venu pour négocier...
            MainPage = new NavigationPage(new ViewClient());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
