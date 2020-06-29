using Blazor.FMEA.Shared.Models.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.FMEA.App.Services.Forms
{
    public interface IDetectionMethodDataService
    {
        Task<IEnumerable<DetectionMethodFormDO>> GetDetectionMethodFormDOs();
    }
}
