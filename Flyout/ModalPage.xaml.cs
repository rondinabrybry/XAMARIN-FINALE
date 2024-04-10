using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flyout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : ContentPage
    {
        public ObservableCollection<ImageData> ImageUrls { get; set; }

        public ModalPage()
        {
            InitializeComponent();

            ImageUrls = new ObservableCollection<ImageData>
            {
                new ImageData { ImageUrl = "_1.jpg", Name = "John Doe", Age = 30 },
                new ImageData { ImageUrl = "_2.jpg", Name = "Jane Doe", Age = 25 },
                new ImageData { ImageUrl = "_3.jpg", Name = "Alice Smith", Age = 35 },
                new ImageData { ImageUrl = "_4.jpg", Name = "John Doe", Age = 30 },
                new ImageData { ImageUrl = "_5.jpg", Name = "Jane Doe", Age = 25 },
                new ImageData { ImageUrl = "_6.jpg", Name = "Alice Smith", Age = 35 }
            };

            BindingContext = this;
        }

        private void CloseModal_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }

    public class ImageData
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}