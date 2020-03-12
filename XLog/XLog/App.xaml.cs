using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLog.View;

namespace XLog
{
    public partial class App : Application
    {
        public App()
        {
            // Controller loading up every xaml 
            InitializeComponent();
            // Loading up our main screen controller
            MainPage = new LoginScreen();
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
