using DogsApp.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DogsApp.ViewModels
{
    class WelcomeViewModel :BaseViewModel
    {
        public ICommand OpenGoogleCommand { get; }
        public ICommand OpenDogsAPICommand { get; }
        public WelcomeViewModel()
        {
            Title = "Welcome";
            OpenGoogleCommand = new AsyncCommand(OpenGoogle);
            OpenDogsAPICommand = new AsyncCommand(OpenDogsAPI);
        }

        private async Task OpenDogsAPI()
        {
            var service = DependencyService.Get<IWebClientService>();
            var content = await service.GetString("https://dog.ceo/api/breeds/list/all");

        }

        private async Task OpenGoogle()
        {
            await Browser.OpenAsync("https://www.google.com");
        }
    }
}
