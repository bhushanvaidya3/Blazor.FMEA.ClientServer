using Blazor.FMEA.App.Services.Forms;
using Blazor.FMEA.Shared.Models.Forms;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.FMEA.Client.Pages.Forms.DetectionMethod
{
    public class DetectionMethodFormBase: ComponentBase
    {
        [Inject]
        public IDetectionMethodDataService DetectionMethodDataService { get; set; }

        public List<DetectionMethodFormDO> detectionMethodFormDOs { get; set; }

        protected override async Task OnInitializedAsync()
        {
            detectionMethodFormDOs = (await DetectionMethodDataService.GetDetectionMethodFormDOs()).ToList();
        }
       
    }
}
