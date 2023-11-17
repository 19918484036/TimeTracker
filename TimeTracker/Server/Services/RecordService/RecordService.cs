namespace TimeTracker.Server.Services.RecordService
{
    public class RecordService : IRecordService
    {
        private readonly DataContext _context; 

        public RecordService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<RecordData>>> GetRecordsAsync()
        {
            var response = new ServiceResponse<List<RecordData>>
            {
                Data = await _context.RecordDatas.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<int>> PostRecordsAsync(RecordData recordData)
        {
            _context.RecordDatas.Add(recordData);
            await _context.SaveChangesAsync();
            return new ServiceResponse<int> { Data = recordData.Id, Message = "Added successfully" };
        }

    }
}
