using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Label1.Text = Write.Text;
        }

        private async void  Button_level_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Game());
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private async void Exit_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new _1());
        }
    }
}