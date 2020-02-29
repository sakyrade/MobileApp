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
	public partial class Bank2 : ContentPage
	{
		public Bank2 ()
		{
			InitializeComponent ();
            labelDate.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            using(HttpClient client = new HttpClient())
            {
                var jsonString = client.GetStringAsync("https://currate.ru/api/?get=rates&pairs=USDRUB,EURRUB&key=8b40624fc04f1041d762e8e9fb748075");
                var jsonObject = JObject.Parse(jsonString);
            }
		}
	}
}