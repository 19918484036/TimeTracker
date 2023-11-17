
namespace TimeTracker.Client.Services.RecordService
{
    public interface IRecordService
    {
        List<RecordData> Records { get; set; }

        Task GetRecords();

        Task<ServiceResponse<int>> PostRecords(RecordData recordData);

    }
}
