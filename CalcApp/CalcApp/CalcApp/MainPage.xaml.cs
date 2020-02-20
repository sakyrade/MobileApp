using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Convert;

namespace CalcApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private char i;
        private double value1, value2, result;

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Label1.Text = "0";
            value1 = 0;
            value2 = 0;
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            i = '/';
            value1 = ToDouble(Label1.Text);
            Label1.Text = "0";
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            double value = 0;
            if (Label1.Text != "0")
                value = ToDouble(Label1.Text) / 100;
            Label1.Text = value.ToString();
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            i = '+';
            value1 = ToDouble(Label1.Text);
            Label1.Text = "0";
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button5.Text;
            else
                Label1.Text += Button5.Text;
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button6.Text;
            else
                Label1.Text += Button6.Text;
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button7.Text;
            else
                Label1.Text += Button7.Text;
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            i = '*';
            value1 = ToDouble(Label1.Text);
            Label1.Text = "0";
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button9.Text;
            else
                Label1.Text += Button9.Text;
        }

        private void Button10_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button10.Text;
            else
                Label1.Text += Button10.Text;
        }

        private void Button11_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button11.Text;
            else
                Label1.Text += Button11.Text;
        }

        private void Button12_Clicked(object sender, EventArgs e)
        {
            i = '-';
            value1 = ToDouble(Label1.Text);
            Label1.Text = "0";
        }

        private void Button13_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button13.Text;
            else
                Label1.Text += Button13.Text;
        }

        private void Button14_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button14.Text;
            else
                Label1.Text += Button14.Text;
        }

        private void Button15_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button15.Text;
            else
                Label1.Text += Button15.Text;
        }

        private void Button16_Clicked(object sender, EventArgs e)
        {
            value2 = ToDouble(Label1.Text);
            switch (i)
            {
                case '+':
                    result = value1 + value2;
                    Label1.Text = result.ToString();
                    break;
                case '-':
                    result = value1 - value2;
                    Label1.Text = result.ToString();
                    break;
                case '/':
                    if (value2 == 0)
                    {
                        DisplayAlert("Ошибка!", "Разделить на ноль нельзя", "OK");
                        value2 = 0;
                    }
                    else
                    {
                        result = value1 / value2;
                        Label1.Text = result.ToString();
                    }
                    break;
                case '*':
                    result = value1 * value2;
                    Label1.Text = result.ToString();
                    break;
                default: Label1.Text = "0"; break;
            }
        }

        private void Button17_Clicked(object sender, EventArgs e)
        {
            if (Label1.Text == "0")
                Label1.Text = Button17.Text;
            else
                Label1.Text += Button17.Text;
        }

        private void Button18_Clicked(object sender, EventArgs e)
        {
            string str = Label1.Text;
            if (str.Contains('.') == false)
                Label1.Text += '.';
        }
    }
}
