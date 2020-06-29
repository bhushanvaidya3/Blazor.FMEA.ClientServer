using Blazor.FMEA.Shared.Models.Forms;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazor.FMEA.App.Services.Forms
{
    public class DetectionMethodDataService : IDetectionMethodDataService
    {
        private readonly HttpClient _httpClient;

        public DetectionMethodDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<DetectionMethodFormDO>> GetDetectionMethodFormDOs()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<DetectionMethodFormDO>>
                (await _httpClient.GetStreamAsync($"api/detectionmethod"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
