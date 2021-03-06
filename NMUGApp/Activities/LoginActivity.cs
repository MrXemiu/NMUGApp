﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using NMUGApp.Core.ViewModels;

namespace NMUGApp.Activities
{
    [Activity(
        Label = "NMUG",
        WindowSoftInputMode = SoftInput.StateHidden,
        MainLauncher = true,
        NoHistory = true,
        LaunchMode = LaunchMode.SingleTop,
        Name = "NMUGApp.Activities.LoginActivity")]
    public class LoginActivity : MvxAppCompatActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_login);
        }
    }
}