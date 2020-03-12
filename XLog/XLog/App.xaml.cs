﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLog.View;

namespace XLog
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

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