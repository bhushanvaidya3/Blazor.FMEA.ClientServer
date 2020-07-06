using Blazor.FMEA.Shared.Models.Forms;
using System.Collections.Generic;

namespace Blazor.FMEA.Api.Data.Master
{
    public interface ISiteMasterRepository
    {
        IEnumerable<SiteMasterDO> GetAll();
    }
}