﻿using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.ViewModels;

namespace NMUGApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public void ShowMasterView()
        {
            ShowViewModel<MasterViewModel>();
        }
    }
}
