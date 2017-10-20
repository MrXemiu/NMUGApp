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
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.master_frame)]
    [Register("NMUGApp.Fragments.MasterFragment")]
    public class MasterFragment : MvxFragment<MasterViewModel>
    {
        /// <inheritdoc />
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.fragment_master, null);

            return view;
        }
    }
}