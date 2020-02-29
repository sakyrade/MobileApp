using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace BankAppSD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                var jsonString = await httpClient.GetStringAsync("https://testandroid-c3393.firebaseio.com/.json");
                var jsonObject = JObject.Parse(jsonString);
                //int i = 0;
                for (int i = 0; i < jsonObject.Count; i++)
                {
                    try
                    {
                        if (jsonObject.Root.ElementAt(i).First["login"].ToString() == entryLogin.Text && jsonObject.Root.ElementAt(i).Last["password"].ToString() == entryPassword.Text)
                        {
                            await Navigation.PushModalAsync(new Bank2());
                            break;
                        }
                        //i++;
                    }
                    catch
                    {
                    }
                }
            
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Bank3());
        }
    }
}
