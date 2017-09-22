using System;

using Xamarin.Forms;

namespace Fitness
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async void BodyPartPage_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ItemsPage());
		}
    }
}
