using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Essentials;

namespace MapApp2
{
    public partial class MainPage : ContentPage
    {
        public static string temp;
        public static string x = "";
        private int count;
        public void InputStart()
        {
            for (int i = 1; i < App.Current.Properties.Count + 1; i++)
                picker.Items.Add(App.Current.Properties[i.ToString()].ToString());
        }
        public MainPage()
        {
            InitializeComponent();
            InputStart();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            picker.Items.Clear();
            picker.Items.Add(entry1.Text + ';' + entry2.Text);
            count = App.Current.Properties.Count + 1;
            App.Current.Properties.Add(count.ToString(), entry1.Text + ';' + entry2.Text);
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = picker.SelectedItem.ToString();
            x = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == ';') break;
                else x += temp[i];
            }
            temp = temp.Remove(0, x.Length + 1);
            Navigation.PushModalAsync(new mapShow());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            count = 0;
            App.Current.Properties.Clear();
            picker.Items.Clear();
        }
    }
}
