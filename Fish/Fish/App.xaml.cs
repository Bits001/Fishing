﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[ assembly: ExportFont("Lato-Bold.ttf", Alias = "Bold")]
[ assembly: ExportFont("Lato-Light.ttf", Alias = "Light")]
[ assembly: ExportFont("Lato-Regular.ttf", Alias = "Regular")]
namespace Fish
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
