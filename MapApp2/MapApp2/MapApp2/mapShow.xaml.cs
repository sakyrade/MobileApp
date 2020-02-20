using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MapApp2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class mapShow : ContentPage
	{
        Xamarin.Forms.Maps.Map map = new Xamarin.Forms.Maps.Map(MapSpan.FromCenterAndRadius(new Position(Convert.ToDouble(MainPage.x), Convert.ToDouble(MainPage.temp)), Distance.FromMiles(0.3)));
        Pin point;
        List<Pin> Pins = new List<Pin>();
        public mapShow()
		{
            //54.941926699999996, 73.40059526854125
            InitializeComponent();
            ts.Children.Add(map);
            Content = ts;
            geoFunc(Convert.ToDouble(MainPage.x), Convert.ToDouble(MainPage.temp));
            
        }
        public void geoFunc(double x, double y)
        {
            point = new Pin()
            {
                Label = "Hello there",
                Position = new Position(x, y)
            };
            Pins.Add(point);
        }
        public void geoFunc2(double x, double y)
        {
            point = new Pin()
            {
                Label = "Hello there",
                Position = new Position(x, y)
            };
            Pins.Add(point);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}