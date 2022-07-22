using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestMobileApp
{
    class StartPage:ContentPage
    {
        public StartPage ()
        {
            Label header = new Label() { Text = "Тест формы" };
            this.Content = header;
        }

    }
}
