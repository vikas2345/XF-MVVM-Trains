using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trains.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShadedButtonPage : ContentPage
	{
		public ShadedButtonPage ()
		{
			InitializeComponent ();
		}


        private void OnAddTask(object sender, EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("Add Task", "Task Added", "Ok");
        }

    }
}