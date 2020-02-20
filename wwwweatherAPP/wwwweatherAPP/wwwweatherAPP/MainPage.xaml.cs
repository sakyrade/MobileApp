using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;

namespace wwwweatherAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var jsongString = await client.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=" + Weather.City + "&appid=b1b35bba8b434a28a0be2a3e1071ae5b&units=metric&lang=ru");
                var jsongObject = JObject.Parse(jsongString);
                label1.Text = "Температура: " + jsongObject["main"]["temp"].Value<string>() + Environment.NewLine + "Состояние погоды: " + jsongObject["weather"][0]["description"].Value<string>() + 
                    Environment.NewLine + "Скорость ветра: " + jsongObject["wind"]["speed"].Value<string>();
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1());
        }
    }
}
