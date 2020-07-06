using Blazor.FMEA.Shared.Models.Forms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazor.FMEA.App.Services.Master
{
    public class SiteMasterDataService : ISiteMasterDataService
    {
        private readonly HttpClient _httpClient;

        public SiteMasterDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<SiteMasterDO>> GetSiteMasterDOs()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<SiteMasterDO>>
                (await _httpClient.GetStreamAsync($"/api/sitemaster"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
