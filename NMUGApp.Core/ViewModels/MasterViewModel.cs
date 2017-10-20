using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using NMUGApp.Core.Models;
using NMUGApp.Core.Services;

namespace NMUGApp.Core.ViewModels
{
    public class MasterViewModel : MvxViewModel
    {
        private readonly IPressReleaseService _pressReleaseService;
        private readonly MvxObservableCollection<Result> _pressReleases;
        private long _pageNumber;
        private long _pageSize;
        private MvxCommand _fetchNext;

        public MvxObservableCollection<Result> PressReleases => _pressReleases;

        public long PageSize
        {
            get => _pageSize;
            set => SetProperty(ref _pageSize, value);
        }

        public long PageNumber
        {
            get => _pageNumber;
            set => SetProperty(ref _pageNumber, value);
        }

        public MvxCommand FetchNext => _fetchNext ?? (_fetchNext = new MvxCommand(async () => { await GetNextPageOfPressReleases(PageNumber + 1); }));




        public MasterViewModel(IPressReleaseService pressReleaseService)
        {
            _pressReleaseService = pressReleaseService;
            _pressReleases = new MvxObservableCollection<Result>();

            PageSize = 2;
        }

        public override async Task Initialize()
        {
            await GetNextPageOfPressReleases(0);
        }

        private async Task GetNextPageOfPressReleases(long pageNumber)
        {
            PressReleases.Clear();

            var result = await _pressReleaseService.GetPressReleaseQueryResult(PageSize, pageNumber);
            PageNumber = result.Metadata.Resultset.Page;

            PressReleases.AddRange(result.Results);
        }
    }
}
