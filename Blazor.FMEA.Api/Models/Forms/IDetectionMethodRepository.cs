using Blazor.FMEA.Shared.Models.Forms;
using System.Collections.Generic;

namespace Blazor.FMEA.Api.Models.Forms
{
    public interface IDetectionMethodRepository
    {
        IEnumerable<DetectionMethodFormDO> GetAll();
    }
}
