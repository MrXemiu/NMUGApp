using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using NMUGApp.Core.ViewModels;

namespace NMUGApp.Activities
{
    [Activity(
        Label = "Main",
        LaunchMode = LaunchMode.SingleTop,
        WindowSoftInputMode = SoftInput.StateHidden,
        Name = nameof(MainActivity))]
    public class MainActivity : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}