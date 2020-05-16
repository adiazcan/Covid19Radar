﻿using System.Collections.Generic;
using System.ComponentModel;
using Covid19Radar.Model;
using Covid19Radar.Resources;
using Covid19Radar.Services;
using Prism.Navigation;
using Xamarin.Forms;

namespace Covid19Radar.ViewModels
{
    public class AppHomePageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public AppHomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "main page";
        }
    }
}