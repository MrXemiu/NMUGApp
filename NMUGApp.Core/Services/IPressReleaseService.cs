using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QuickType;

namespace NMUGApp.Core.Services
{
    public interface IPressReleaseService
    {
        Task<PressReleaseQueryResult> GetPressReleaseQueryResult(int pageNumber);
    }
}
