using Blazor.FMEA.App.Services.Forms;
using Blazor.FMEA.Shared.Models.Forms;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.FMEA.Client.Pages.Forms.DetectionMethod
{
    public class DetectionMethodFormDetailBase : ComponentBase
    {
        [Inject]
        private NavigationManager navigationManager { get; set; }

        [Inject]
        public IDetectionMethodDataService DetectionMethodDataService { get; set; }

        [Parameter]
        public string DetectionId { get; set; }

        public DetectionMethodFormDO DetectionMethodFormDO { get; set; } = new DetectionMethodFormDO();

        protected override async Task OnInitializedAsync()
        {
            DetectionMethodFormDO = (await DetectionMethodDataService.GetDetectionMethodFormDOs()).Where(x => x.Detection_ID == int.Parse(DetectionId)).FirstOrDefault();
        }

        protected void HandleValidSubmit()
        {
            try
            {

            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        protected void HandleNavigateToListPage()
        {
            navigationManager.NavigateTo("/detectionmethodform");
        }
    }
}
