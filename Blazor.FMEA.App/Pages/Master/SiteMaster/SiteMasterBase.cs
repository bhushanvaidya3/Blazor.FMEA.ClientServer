using Blazor.FMEA.App.Services.Master;
using Blazor.FMEA.Shared.Models.Forms;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.FMEA.App.Pages.Master.SiteMaster
{
    public class SiteMasterBase: ComponentBase
    {
        [Inject]
        public ISiteMasterDataService SiteMasterDataService { get; set; }
        public List<SiteMasterDO> siteMasterDOs { get; set; }

        protected override async Task OnInitializedAsync()
        {
            siteMasterDOs = (await SiteMasterDataService.GetSiteMasterDOs()).ToList();
        }
    }
}
