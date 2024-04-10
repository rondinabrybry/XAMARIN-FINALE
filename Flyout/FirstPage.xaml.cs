using System;
using Xamarin.Forms;

namespace Flyout
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var modalPage = new ModalPage();
            await Navigation.PushModalAsync(modalPage);
        }
    }
}
