using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Core;
using NMUGApp.Core.Services;
using NMUGApp.Core.ViewModels;

namespace NMUGApp.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IHttpClientService, HttpClientService>();
            Mvx.RegisterType<IPressReleaseService, PressReleaseService>();

            RegisterNavigationServiceAppStart<LoginViewModel>();
        }
    }
}
