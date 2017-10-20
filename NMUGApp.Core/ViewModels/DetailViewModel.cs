using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.ViewModels;

namespace NMUGApp.Core.ViewModels
{
    public class DetailViewModel : MvxViewModel<string>
    {
        private string _body;
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public string Body
        {
            get => _body;
            set => SetProperty(ref _body, value);
        }

        /// <inheritdoc />
        public override void Prepare(string parameter)
        {
            Body = parameter;
        }
    }
}
