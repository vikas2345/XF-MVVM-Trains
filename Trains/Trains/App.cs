using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross;
using Trains;
using MvvmCross.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.Localization;

namespace Trains
{
    public partial class App1 : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes().EndingWith("Repository").AsInterfaces().RegisterAsLazySingleton();

            CreatableTypes().EndingWith("Services").AsInterfaces().RegisterAsLazySingleton();

            //Mvx.RegisterSingleton<IMvxTextProvider>(new ResxTextprovider);

            RegisterAppStart(new AppStart());
        }
    }
}
