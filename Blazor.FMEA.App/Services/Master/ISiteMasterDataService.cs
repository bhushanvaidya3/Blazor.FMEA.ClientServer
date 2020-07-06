using Blazor.FMEA.Shared.Models.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.FMEA.App.Services.Master
{
    public interface ISiteMasterDataService
    {
        Task<IEnumerable<SiteMasterDO>> GetSiteMasterDOs();
    }
}