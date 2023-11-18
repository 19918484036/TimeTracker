
using TimeTracker.Client.Pages;

namespace TimeTracker.Client.Services.RecordService
{
    public interface IRecordService
    {
        List<RecordData> Records { get; set; }

        Task GetRecords();

        Task<ServiceResponse<int>> PostRecords(RecordData recordData);

        Task<ServiceResponse<bool>> DeleteRecords(int RecordId);

    }
}
