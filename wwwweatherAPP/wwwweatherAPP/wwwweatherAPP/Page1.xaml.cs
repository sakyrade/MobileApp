using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wwwweatherAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        private int count;
        public void InputStart()
        {
            for (int i = 1; i < App.Current.Properties.Count + 1; i++)
            {
                Picker1.Items.Add(App.Current.Properties[i.ToString()].ToString());
            }
        }
		public Page1 ()
		{
			InitializeComponent ();
            InputStart();
		}

        private void Picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Weather.City = Picker1.SelectedItem.ToString();
            Navigation.PushModalAsync(new MainPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Picker1.Items.Clear();
            count = App.Current.Properties.Count + 1;
            App.Current.Properties.Add(count.ToString(), Entry1.Text);
            InputStart();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            count = 0;
            App.Current.Properties.Clear();
            Picker1.Items.Clear();
        }
    }
}