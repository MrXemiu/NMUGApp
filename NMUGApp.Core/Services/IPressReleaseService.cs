using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NMUGApp.Core.Models;

namespace NMUGApp.Core.Services
{
    public interface IPressReleaseService
    {
        Task<PressReleaseQueryResult> GetPressReleaseQueryResult(long pageSize, long pageNumber);
    }
}
