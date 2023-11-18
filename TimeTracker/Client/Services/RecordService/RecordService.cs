using TimeTracker.Shared;

namespace TimeTracker.Client.Services.RecordService
{
    public class RecordService : IRecordService
    {
        private readonly HttpClient _HttpClient;
        public RecordService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }
        
        public List<RecordData> Records { get; set; } = new List<RecordData>();
        public async Task GetRecords()
        {
            var result = await _HttpClient.GetFromJsonAsync<ServiceResponse<List<RecordData>>>("api/Record");
            if(result!=null || result.Data != null)
            {
                Records = result.Data;
            }
            
        }

        public async Task<ServiceResponse<int>> PostRecords(RecordData recordData)
        {
            var result = await _HttpClient.PostAsJsonAsync("api/Record", recordData);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }

        public async Task<ServiceResponse<bool>> DeleteRecords(int RecordId)
        {
            var result = await _HttpClient.DeleteAsync($"api/Record?RecordId={RecordId}");
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }
    }
}
