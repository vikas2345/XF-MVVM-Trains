using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.Diagnostics;

namespace Trains.ViewModel
{
    public class SamplePageViewModel
    {
        public ICommand ClCommand { get; }

        public SamplePageViewModel()
        {
            ClCommand = new Command(ClickCommand);
        }
         
        public void ClickCommand()
        {
            Debug.WriteLine("I Command Binding");
        }
    }
}
