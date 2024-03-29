﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fish
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        Page onboardingPage;
        public MainPage()
        {
            InitializeComponent();

            if (ShouldShowOnboarding()== true)
            {
                App.Current.ModalPopping += Current_ModalPopping;
                onboardingPage = new OnboardingPage();
                Navigation.PushModalAsync(onboardingPage, false);

            }
        }

        private void Current_ModalPopping(object sender, ModalPoppingEventArgs e)
        {
           if(e.Modal == onboardingPage)
            {
                FadeBox.FadeTo(0, 1000);
                onboardingPage = null;
                App.Current.ModalPopping -= Current_ModalPopping;
            }
        }

        private bool ShouldShowOnboarding()
        {
            return true; 
            //return VersionTracking.IsFirstLaunchEver;
        }
    }
}
