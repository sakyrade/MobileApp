using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace chat
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                label1.Text = "";
                get();
                return true;
            });

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                JObject oJsonObject = new JObject();
                oJsonObject.Add("key", entry1.Text+": "+entry2.Text);
                var jsonString = await client.PostAsync("https://chat-7b085.firebaseio.com/.json", new StringContent(oJsonObject.ToString()));
            }
        }
        public async void get()
        {
            using (var client = new HttpClient())
            {
                var jsonString = await client.GetStringAsync("https://chat-7b085.firebaseio.com/.json");
                var jsonObject = JObject.Parse(jsonString);
                for (int i = 0; i < jsonObject.Count; i++)
                {
                    try
                    {
                        label1.Text += Environment.NewLine + jsonObject.Root.ElementAt(i).First["key"].ToString();
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
