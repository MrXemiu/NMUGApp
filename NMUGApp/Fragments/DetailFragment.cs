using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;
using NMUGApp.Core.ViewModels;

namespace NMUGApp.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.detail_frame)]
    [Register("NMUGApp.Fragments.DetailFragment")]
    public class DetailFragment : MvxFragment<DetailViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.fragment_detail, null);

            return view;
        }
    }
}