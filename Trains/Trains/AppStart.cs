using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross;
using MvvmCross.Core.ViewModels;

namespace Trains
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            //var userService = Mvx.Resolve<IUserDataService>();

            //userService.Login("","");

            //ShowViewModel<MainViewModel>();
        }
    }
}
