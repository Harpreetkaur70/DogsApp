using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DogsApp.Droid.Services;
using DogsApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;
using System.Text;
using System.Threading.Tasks;
[assembly: Dependency(typeof(WebClientService))]
namespace DogsApp.Droid.Services
{
    class WebClientService : IWebClientService
    {
        public async Task<string> GetString(string Uri)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(Uri);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return null;
        }
    }
}