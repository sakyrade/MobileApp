using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankAppSD
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bank3 : ContentPage
	{
		public Bank3 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (entryRegLogin.Text != "" && entryRegPassword.Text != "")
            {
                using (var client = new HttpClient())
                {
                    JObject oJsonObject = new JObject();
                    oJsonObject.Add("login", entryRegLogin.Text);
                    oJsonObject.Add("password", entryRegPassword.Text);
                    var jsonString = await client.PostAsync("https://testandroid-c3393.firebaseio.com/.json", new StringContent(oJsonObject.ToString()));
                }
                await Navigation.PushModalAsync(new MainPage());
            }
        }
    }
}