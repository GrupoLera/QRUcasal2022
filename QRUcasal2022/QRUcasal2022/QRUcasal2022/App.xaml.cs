using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRUcasal2022
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] {"Expander_Experimental"});

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
