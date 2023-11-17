namespace TimeTracker.Server.Services.RecordService
{
    public interface IRecordService
    {
        Task<ServiceResponse<List<RecordData>>> GetRecordsAsync();
    }
}
