namespace TimeTracker.Server.Services.RecordService
{
    public interface IRecordService
    {
        Task<ServiceResponse<List<RecordData>>> GetRecordsAsync();

        Task<ServiceResponse<int>> PostRecordsAsync(RecordData recordData);

        Task<ServiceResponse<bool>> RemoveRecordAsync(int RecordId);
    }
}
