using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace HTTPappSD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (switch1.IsToggled==true)
            {
                using (var client = new HttpClient())
                {
                    var jsonString = await client.GetStringAsync("https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20200127T021115Z.4b733ce5cb4923b2.1537223d16c21c0089e1d656b97ac03313c02630&text=" + entry3.Text + "&lang=ru-en");
                    var jsonObject = JObject.Parse(jsonString);
                    MailAddress from = new MailAddress("tests-test83@mail.ru", "Magazine");
                    MailAddress to = new MailAddress(entry1.Text);
                    MailMessage message = new MailMessage(from, to);
                    message.Subject = entry2.Text;
                    message.Body = jsonObject["text"][0].Value<string>();
                    SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                    smtp.Credentials = new NetworkCredential("tests-test83@mail.ru", "FWERE3VUY4");
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
            }
            else if(switch1.IsToggled==false)
            {
                using (var client = new HttpClient())
                {
                    var jsonString = await client.GetStringAsync("https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20200127T021115Z.4b733ce5cb4923b2.1537223d16c21c0089e1d656b97ac03313c02630&text=" + entry3.Text + "&lang=en-ru");
                    var jsonObject = JObject.Parse(jsonString);
                    MailAddress from = new MailAddress("tests-test83@mail.ru", "Magazine");
                    MailAddress to = new MailAddress(entry1.Text);
                    MailMessage message = new MailMessage(from, to);
                    message.Subject = entry2.Text;
                    message.Body = jsonObject["text"][0].Value<string>();
                    SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                    smtp.Credentials = new NetworkCredential("tests-test83@mail.ru", "FWERE3VUY4");
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
            }
        }



        private void Slider1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            entry3.FontSize = slider1.Value;
        }
    }
}
