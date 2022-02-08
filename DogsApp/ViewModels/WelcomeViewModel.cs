using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;

namespace DogsApp.ViewModels
{
    class WelcomeViewModel :BaseViewModel
    {
        public ICommand OpenGoogleCommand { get; }
        public WelcomeViewModel()
        {
            Title = "Welcome";
            OpenGoogleCommand = new AsyncCommand(OpenGoogle);
        }
        private async Task OpenGoogle()
        {
            await Browser.OpenAsync("https://www.google.com");
        }
    }
}
