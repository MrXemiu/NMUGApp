using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace NMUGApp.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string _username;
        private string _password;
        private MvxCommand _submitLogin;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _username, value);
        }

        public MvxCommand SubmitLogin
        {
            get
            {
                return _submitLogin ?? (_submitLogin = new MvxCommand(() =>
                {
                    ShowViewModel<MainViewModel>();
                }));
            }
        }
    }
}
