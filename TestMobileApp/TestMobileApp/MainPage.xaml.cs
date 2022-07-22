using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TestMobileApp.Messages;
using Xamarin.Forms;

namespace TestMobileApp
{
    public partial class MainPage : ContentPage
    {
        const string Url = "http://62.109.29.127:80/api/ToMobile/";

        // настройки для десериализации для нечувствительности к регистру символов
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        public MainPage()
        {
            InitializeComponent();
         
        }

    
        private async Task button1_ClickedAsync(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            string result = await client.GetStringAsync(Url);
            List<ComputerList> computers = JsonSerializer.Deserialize<List<ComputerList>>(result, options);

            Label label = new Label() { Text = computers[0].ComputerId};
            stackLayout.Children.Add(label);

            //Label label2 = new Label() { Text = "asdkfjhgaskjfhasf", };
            //Label label3 = new Label() { Text = " sadfasd", BackgroundColor = Color.Blue };
            //StackLayout horizontalStackLayout = new StackLayout() { Orientation = StackOrientation.Horizontal};
            //horizontalStackLayout.Children.Add(label2);
            //horizontalStackLayout.Children.Add(label3);
            //stackLayout.Children.Insert(3, horizontalStackLayout);
            //Image image = new Image { Source = "images.jpg" };
            //this.Content = image;




        }
    }
}
