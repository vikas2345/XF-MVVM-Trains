using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trains.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trains.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SamplePage : ContentPage
	{
        SamplePageViewModel viewModel;
		public SamplePage ()
		{
			InitializeComponent ();
            //viewModel = new SamplePageViewModel();
            //BindingContext = viewModel;
		}

        private async void ClickMe_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Click", "Button Clicked", "Oke");
        }
    }
}