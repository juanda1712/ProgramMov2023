﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgramMov2023
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new  NavigationPage(new Bidning_example());
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
