using Blazor.FMEA.Shared.Models.Forms;
using System.Collections.Generic;

namespace Blazor.FMEA.Api.Data.Forms
{
    public interface IDetectionMethodRepository
    {
        IEnumerable<DetectionMethodFormDO> GetAll();
    }
}
